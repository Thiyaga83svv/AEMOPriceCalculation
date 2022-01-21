using System;using Xunit;
using AutoFixture;
using AEMOPriceCalculation.Services;
using Moq;
using FluentAssertions;
using AEMOPriceCalculation.BusinessLogic;

namespace AEMOPriceCalculation.UnitTests.Services
{
    public class DiscountServiceTests : UnitTests
    {
        [Fact]
        public void CalclulateDiscountShouldReturnDiscountedValue()
        {
            var calculateDateMock = "22-01-2022";
            var priceMock = 10.0m;

            Fixture.Freeze<Mock<ICalculateDiscount>>()
                                        .Setup(r => r.CalculateDiscountByDay(It.IsAny<decimal>()))
                                        .Returns(9.0m);

            var sut = Fixture.Create<DiscountService>();

            var result = sut.CalclulateDiscount(priceMock, calculateDateMock);

            result.Should().Be(9.0m);


        }

        [Fact]
        public void CalclulateDiscountShouldReturnOrignalValue()
        {
            var calculateDateMock = "21-01-2022";
            var priceMock = 10.0m;

            Fixture.Freeze<Mock<ICalculateDiscount>>()
                                        .Setup(r => r.CalculateDiscountByDay(It.IsAny<decimal>()))
                                        .Returns(9.0m);

            var sut = Fixture.Create<DiscountService>();

            var result = sut.CalclulateDiscount(priceMock, calculateDateMock);

            result.Should().Be(10.0m);


        }

        [Fact]
        public void CalclulateDiscountShouldCallCalculateDiscountClass()
        {
            var calculateDateMock = "22-01-2022";
            var priceMock = 10.0m;

            var CalculateDiscountMock = Fixture.Freeze<Mock<ICalculateDiscount>>();

            var sut = Fixture.Create<DiscountService>();

            var result = sut.CalclulateDiscount(priceMock, calculateDateMock);

            CalculateDiscountMock.Verify(m => m.CalculateDiscountByDay(It.IsAny<decimal>()), Times.Once);


        }
        [Fact]
        public void CalclulateDiscountShouldNotCallCalculateDiscountClass()
        {
            var calculateDateMock = "21-01-2022";
            var priceMock = 10.0m;

            var CalculateDiscountMock = Fixture.Freeze<Mock<ICalculateDiscount>>();

            var sut = Fixture.Create<DiscountService>();

            var result = sut.CalclulateDiscount(priceMock, calculateDateMock);

            CalculateDiscountMock.Verify(m => m.CalculateDiscountByDay(It.IsAny<decimal>()), Times.Never);


        }
    }
}
