using System;
using System.Collections.Generic;
using System.Linq;

namespace HarryPotterShoppingCart
{
    public class HarryPotterShoppingCartService
    {
        private readonly Dictionary<int, decimal> _discountRules;

        public HarryPotterShoppingCartService()
        {
            _discountRules = new Dictionary<int, decimal> {
                {1,1 },
                {2,0.95m },
                {3,0.9m },
                {4,0.8m },
                {5,0.75m }
            };
        }

        public decimal CheckOut(List<FantasyNovel> shoppingList)
        {
            //複製一個副本出來
            var shoppingListCopy = shoppingList.Select(s => s).ToList();
            return CheckOutImpl(shoppingListCopy);
        }

        private decimal CheckOutImpl(List<FantasyNovel> shoppingListCopy)
        {
            var total = 0m;
            while (shoppingListCopy.Any())
            {
                //群組後取第一個
                var distinctShoppingList = shoppingListCopy.Distinct(s => s.Id).ToList();
                var distinctCount = distinctShoppingList.Count();
                var distinctTotal = distinctShoppingList.Sum(d => d.UnitPrice);

                total += CalculateTotal(distinctTotal, distinctCount);

                //將已取出的由副本移掉等一下才不會重複取到
                shoppingListCopy.RemoveAll(sc => distinctShoppingList.Contains(sc));
            }

            return total;
        }

        private decimal CalculateTotal(int total, int count)
        {
            decimal discountRate;
            _discountRules.TryGetValue(count, out discountRate);

            return total * discountRate;
        }
    }

    public static class EnumerableExtenstions
    {
        public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
        {
            var keys = new HashSet<TKey>();
            foreach (var element in source)
            {
                var elementValue = keySelector(element);
                if (keys.Add(elementValue))
                {
                    yield return element;
                }
            }
        }
    }
}