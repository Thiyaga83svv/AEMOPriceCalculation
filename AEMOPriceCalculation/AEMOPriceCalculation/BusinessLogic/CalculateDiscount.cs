using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEMOPriceCalculation.BusinessLogic
{
    public class CalculateDiscount : ICalculateDiscount
    {
        public decimal CalculateDiscountByDay(decimal price)
        {
            return price - (price / 100) * 10;
        }
    }
}
