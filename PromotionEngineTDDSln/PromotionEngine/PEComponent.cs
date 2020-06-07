using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PEComponent
    {
        public double GetTotal(List<string> ListOfProducts)
        {
            var frequencyOfProductsInBasket = ListOfProducts.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            frequencyOfProductsInBasket.TryGetValue("A", out int CountOfProdA);
            frequencyOfProductsInBasket.TryGetValue("B", out int CountOfProdB);
            frequencyOfProductsInBasket.TryGetValue("C", out int CountOfProdC);
            frequencyOfProductsInBasket.TryGetValue("D", out int CountOfProdD);

            return 0;
        }

    }
}
