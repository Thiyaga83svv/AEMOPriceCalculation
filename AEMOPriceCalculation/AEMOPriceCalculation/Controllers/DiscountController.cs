using AEMOPriceCalculation.Model;
using AEMOPriceCalculation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEMOPriceCalculation.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;
        private readonly ILogger<DiscountController> _logger;

        public DiscountController(IDiscountService discountService, 
                                  ILogger<DiscountController> logger)
        {
            _discountService = discountService;
            _logger = logger;
        }
        [HttpPost]
        [Route("price")]
        public JsonResult CalculatePrice(EnergyPrice energyPrice)
        {
            var calculatedPrice = _discountService.CalclulateDiscount(energyPrice.Price, energyPrice.CalculationDate);
            _logger.LogInformation("Price calculated for {0} is {1}", energyPrice.EngeryType, calculatedPrice);
            return new JsonResult(calculatedPrice);
        }
    }
}
