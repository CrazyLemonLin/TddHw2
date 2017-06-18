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
            decimal result = 0 ;

            if (shoppingList.Count >=2)
            {
                return total *0.95m;
            }

            return total;
        }
    }
}
