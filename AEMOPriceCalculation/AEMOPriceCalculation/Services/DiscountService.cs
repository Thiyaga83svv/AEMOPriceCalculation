using AEMOPriceCalculation.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEMOPriceCalculation.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly ICalculateDiscount _calcluateDiscount;

        public DiscountService(ICalculateDiscount calcluateDiscount)
        {
            _calcluateDiscount = calcluateDiscount;
        }
        public decimal CalclulateDiscount(decimal price, string calculationDate)
        {
            var convertedDate = Convert.ToDateTime(calculationDate);
            if(convertedDate.DayOfWeek == DayOfWeek.Sunday || convertedDate.DayOfWeek == DayOfWeek.Saturday)
            {
               return _calcluateDiscount.CalculateDiscountByDay(price);
            }
            return price;
        }
    }
}
