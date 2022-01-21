using FluentAssertions;
using Moq;
using AutoFixture;
using Xunit;
using AEMOPriceCalculation.BusinessLogic;

namespace AEMOPriceCalculation.UnitTests.BusinessLogic
{
    public class CalculateDiscountTests : UnitTests
    {

        [Theory]
        [InlineData(10.0,9.0)]
        [InlineData(0.0, 0.0)]
        public void CalculateDiscountByDayShouldReturnCorrectValue(decimal price, decimal output)
        { 

            var sut = Fixture.Create<CalculateDiscount>();

            var result = sut.CalculateDiscountByDay(price);

            result.Should().Be(output);
        }
    }
}
