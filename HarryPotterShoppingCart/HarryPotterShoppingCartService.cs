using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var shoppingListCopy = shoppingList.Select(s => s).ToList();
            var total = 0m;
            while (shoppingListCopy.Any())
            {
                var distinctShoppingList = shoppingListCopy.GroupBy(s => s.Id).Select(g => g.First());
                var distinctCount = distinctShoppingList.Count();
                var distinctTotal = distinctShoppingList.Sum(d => d.UnitPrice);
                total += CheckOutImpl(distinctTotal, distinctCount);
                shoppingListCopy.RemoveAll(sc => distinctShoppingList.Contains(sc));
            }

            return total;
        }

        private decimal CheckOutImpl(int total, int count)
        {
            decimal discountRate;
            _discountRules.TryGetValue(count, out discountRate);

            return total * discountRate;
        }
    }
}
