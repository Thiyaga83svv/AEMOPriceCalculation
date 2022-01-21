using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEMOPriceCalculation.Services
{
    public interface IDiscountService
    {
        public decimal CalclulateDiscount(decimal price, string calculationDate);
    }
}
