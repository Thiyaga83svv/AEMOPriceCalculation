using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEMOPriceCalculation.Model
{
    public class EnergyPrice
    {
        public string CalculationDate { get; set; }

        public string EngeryType { get; set; }

        public decimal Price { get; set; }
    }
}
