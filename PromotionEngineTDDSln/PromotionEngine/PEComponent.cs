using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PEComponent
    {
        /// <summary>
        /// Get the total of all the productions in basket, by applying the promotions
        /// </summary>
        /// <param name="ListOfProducts"></param>
        /// <returns></returns>
        public double GetTotal(List<string> ListOfProducts)
        {
            var frequencyOfProductsInBasket = ListOfProducts.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            frequencyOfProductsInBasket.TryGetValue("A", out int CountOfProdA);
            frequencyOfProductsInBasket.TryGetValue("B", out int CountOfProdB);
            frequencyOfProductsInBasket.TryGetValue("C", out int CountOfProdC);
            frequencyOfProductsInBasket.TryGetValue("D", out int CountOfProdD);

            double finalPriceOfProdA = (CountOfProdA / 3) * 130 + (CountOfProdA % 3 * ProductPrice.PriceOfProdA);
            double finalPriceOfProdB = (CountOfProdB / 2) * 45 + (CountOfProdB % 2 * ProductPrice.PriceOfProdB);
            double finalPriceOfProdC = CountOfProdD > 0 ? (CountOfProdC / 1) * 0 + (CountOfProdC % 1 * ProductPrice.PriceOfProdC) : (CountOfProdC * ProductPrice.PriceOfProdC);
            double finalPriceOfProdD = CountOfProdC > 0 ? (CountOfProdD / 1) * 30 + (CountOfProdD % 1 * ProductPrice.PriceOfProdD) : (CountOfProdD * ProductPrice.PriceOfProdD);


            return finalPriceOfProdA + finalPriceOfProdB + finalPriceOfProdC + finalPriceOfProdD;
        }

    }
}
