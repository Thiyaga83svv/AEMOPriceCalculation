using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEMOPriceCalculation.BusinessLogic
{
    public interface ICalculateDiscount
    {
        decimal CalculateDiscountByDay(decimal price);
    }
}
