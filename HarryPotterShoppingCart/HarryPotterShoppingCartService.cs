using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterShoppingCart
{
    public class HarryPotterShoppingCartService
    {
        public decimal CheckOut(List<FantasyNovel> shoppingList)
        {
            var total = shoppingList.Sum(s => s.UnitPrice);

            var count = shoppingList.Distinct().Count();

            return CheckOutImpl(total, count);
        }

        private static decimal CheckOutImpl(int total, int count)
        {
            if (count >= 4)
            {
                return total * 0.8m;
            }
            else if (count >= 3)
            {
                return total * 0.9m;
            }
            else if (count >= 2)
            {
                return total * 0.95m;
            }

            return total;
        }
    }
}
