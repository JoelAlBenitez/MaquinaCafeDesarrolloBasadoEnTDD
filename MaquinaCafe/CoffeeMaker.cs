namespace MaquinaCafe
{
    public class CoffeeMaker
    {

        private int CoffeeQuantity;

        public CoffeeMaker(int coffeeQuantity) {

            CoffeeQuantity = coffeeQuantity;
        }

        public void SetCoffeeQuantity(int coffeeQuantity) => CoffeeQuantity = coffeeQuantity;

        public int GetCoffeeQuantity() => CoffeeQuantity;

        public bool HasCoffee(int coffeeQuantity) => CoffeeQuantity >= coffeeQuantity;

        public void GiveCoffee(int coffeeQuantity) => CoffeeQuantity -= coffeeQuantity;

    }
}
