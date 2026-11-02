using Xunit.Sdk;
using MaquinaCafe;

namespace MaquinaCafeTest
{
    public class SugarBowlTest
    {
        SugarBowl sugarBowl;

       
        public SugarBowlTest()
        {
            sugarBowl = new SugarBowl(10);
        }


        [Fact]
        public void ShouldReturnTrueIfThereIsEnoughSugarInTheSugarBowl()
        {
            bool result = sugarBowl.HasSugar(5);

            Assert.True(result);

            result = sugarBowl.HasSugar(10);

            Assert.True(result);

        }

        [Fact]
        public void ShouldReturnFalseBecauseThereIsNotEnoughSugarInTheSugarBowl()
        {
            bool result = sugarBowl.HasSugar(15);

            Assert.False(result);
        }

        [Fact]
        public void ShouldSubtractSugarOfSugarBowl()
        {
            sugarBowl.GiveSugar(5);

            Assert.Equal(5, sugarBowl.GetQuantitySugar());

            sugarBowl.GiveSugar(2);

            Assert.Equal(3, sugarBowl.GetQuantitySugar());

        }

    }
}
