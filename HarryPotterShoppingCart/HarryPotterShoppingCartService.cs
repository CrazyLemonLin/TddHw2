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
            var total = shoppingList.Sum(s => s.UnitPrice);

            var count = shoppingList.Distinct().Count();

            return CheckOutImpl(total, count);
        }

        private decimal CheckOutImpl(int total, int count)
        {
            decimal discountRate;
            _discountRules.TryGetValue(count, out discountRate);

            return total * discountRate;
        }
    }
}
