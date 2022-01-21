using AutoFixture;
using AutoFixture.AutoMoq;

namespace AEMOPriceCalculation.UnitTests
{
    public abstract class UnitTests
    {
        protected UnitTests()
        {
            Fixture = new Fixture();
            Fixture.Customize(new AutoMoqCustomization());
        }
        protected IFixture Fixture { get; }
    }
}
