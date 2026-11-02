using MaquinaCafe;

namespace MaquinaCafeTest
{
    public class CoffeeMakerTest
    {
        [Fact]

        public void ReturnTrueCoffeeExit()
        {
            CoffeeMaker coffee = new CoffeeMaker(10);

            bool result = coffee.HasCoffee(5);

            Assert.True(result);
        }

        [Fact]

        public void ReturnFalseCoffeeNoExit() {

            CoffeeMaker coffee = new CoffeeMaker(10);

            bool result = coffee.HasCoffee(11);

            Assert.False(result);
        }

        [Fact]

        public void SubtractCoffeeOfCoffeeMaker()
        {
            CoffeeMaker coffee = new CoffeeMaker(10);

            coffee.GiveCoffee(7);

            Assert.Equal(3, coffee.GetCoffeeQuantity());
        }
    }
}
