using MaquinaCafe;

namespace MaquinaCafeTest
{
    public class CoffeeMachineTest
    {

        CoffeeMaker coffeeMaker;
        Glasses smallGlasses;
        Glasses bigGlasses;
        Glasses mediumGlasses;
        SugarBowl sugarBowl;
        CoffeeMachine coffeeMachine;

        public CoffeeMachineTest(
         
            ) {

            coffeeMaker = new CoffeeMaker(50);
            smallGlasses = new Glasses(5, 10);
            bigGlasses = new Glasses(5, 30);
            mediumGlasses = new Glasses(5, 20);
            sugarBowl = new SugarBowl(20);

            coffeeMachine = new CoffeeMachine();

            coffeeMachine.SetCoffeeMaker(coffeeMaker);
            coffeeMachine.SetSmallGlasses(smallGlasses);
            coffeeMachine.SetBigGlasses(bigGlasses);
            coffeeMachine.SetMediumGlasses(mediumGlasses);
            coffeeMachine.SetSugarBowl(sugarBowl);
        }

        [Fact]
        public void ShouldReturnASmallGlasses()
        {
            Glasses smallGlasses = coffeeMachine.GetTypeGlasses("small");

            Assert.Equal(coffeeMachine.GetSmallGlasses(), smallGlasses);
        }

        [Fact]

        public void ShouldReturnAMediumGlasses()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            Glasses mediumGlasses = coffeeMachine.GetTypeGlasses("medium");

            Assert.Equal(coffeeMachine.GetMediumGlasses(), mediumGlasses);
        }

        [Fact]

        public void ShouldReturnABigGlasses()
        {

            Glasses bigGlasses = coffeeMachine.GetTypeGlasses("big");

            Assert.Equal(coffeeMachine.GetBigGlasses(), bigGlasses);
        }

        [Fact]

        public void ShouldThereArentGlasses()
        {
            Glasses glasses = coffeeMachine.GetTypeGlasses("small");

            string result = coffeeMachine.GetCoffeeGlasses(glasses, 10, 2);

            Assert.Equal("There aren't glasses", result);
        }

        [Fact]

        public void ShouldReturnThereArentCoffee()
        {
            coffeeMaker = new CoffeeMaker(5);
           
            coffeeMachine.SetCoffeeMaker(coffeeMaker);

            Glasses glasses = coffeeMachine.GetTypeGlasses("small");

            string result = coffeeMachine.GetCoffeeGlasses(glasses, 1, 2);

            Assert.Equal("There aren't coffee", result);
        }

        [Fact]

        public void ShouldReturnThereArentSugar()
        {
            sugarBowl = new SugarBowl(2);

            coffeeMachine.SetSugarBowl(sugarBowl);

            Glasses glasses = coffeeMachine.GetTypeGlasses("small");

            string result = coffeeMachine.GetCoffeeGlasses(glasses, 1, 3);

            Assert.Equal("There aren't sugar", result);
        }

        [Fact] 

        public void ShouldSubtractCoffee()
        {
            Glasses glasses = coffeeMachine.GetTypeGlasses("small");

            coffeeMachine.GetCoffeeGlasses(glasses, 1, 3);

            int result = coffeeMachine.GetCoffeeMaker().GetCoffeeQuantity();

            Assert.Equal(40, result);
        }

        [Fact]

        public void ShouldSubtractGlasses() {

            Glasses glasses = coffeeMachine.GetTypeGlasses("small");

            coffeeMachine.GetCoffeeGlasses(glasses, 1, 3);

            int result = coffeeMachine.GetSmallGlasses().GetNumberGlasses();
            
            Assert.Equal(4, result);
        }

        [Fact]

        public void ShouldSubtractSugar()
        {
            Glasses glasses = coffeeMachine.GetTypeGlasses("small");
            
            coffeeMachine.GetCoffeeGlasses(glasses, 1, 3);

            int result = coffeeMachine.GetSugarBowl().GetQuantitySugar();

            Assert.Equal(17, result);
        }

        [Fact]

        public void ShouldReturnCongratulations()
        {
            Glasses glasses = coffeeMachine.GetTypeGlasses("small");

            string result = coffeeMachine.GetCoffeeGlasses(glasses, 1, 3);

            Assert.Equal("Congratulations", result);
        }
    }
}
