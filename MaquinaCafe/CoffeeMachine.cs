namespace MaquinaCafe
{
    public class CoffeeMachine
    {
        private CoffeeMaker? coffeeMaker;
        private Glasses? smallGlasses;
        private Glasses? mediumGlasses;
        private Glasses? bigGlasses;
        private SugarBowl? sugarBowl;

        public void SetCoffeeMaker(CoffeeMaker coffeeMaker) => this.coffeeMaker = coffeeMaker;
        public void SetSmallGlasses(Glasses smallGlasses) => this.smallGlasses = smallGlasses;
        public void SetMediumGlasses(Glasses mediumGlasses) => this.mediumGlasses = mediumGlasses;
        public void SetBigGlasses(Glasses bigGlasses) => this.bigGlasses = bigGlasses;
        public void SetSugarBowl(SugarBowl sugarBowl) => this.sugarBowl = sugarBowl;


        public CoffeeMaker GetCoffeeMaker() => coffeeMaker!;
        public Glasses GetSmallGlasses() => smallGlasses!;
        public Glasses GetMediumGlasses() => mediumGlasses!;
        public Glasses GetBigGlasses() => bigGlasses!;
        public SugarBowl GetSugarBowl() => sugarBowl!;

        public Glasses GetTypeGlasses(string typeGlasses)
        {
            if (typeGlasses == "medium") return mediumGlasses!;
            if (typeGlasses == "big") return bigGlasses!;
            return smallGlasses!;
        }

        public string GetCoffeeGlasses(Glasses glasses, int quantityGlasses, int quantitySugar)
        {
            if (glasses == null || !glasses.HasGlasses(quantityGlasses))
            {
                return "There aren't glasses";
            }

            int totalCoffeeNeeded = glasses.GetContent() * quantityGlasses;
            if (coffeeMaker == null || !coffeeMaker.HasCoffee(totalCoffeeNeeded))
            {
                return "There aren't coffee";
            }

            if (sugarBowl == null || !sugarBowl.HasSugar(quantitySugar))
            {
                return "There aren't sugar";
            }

            glasses.GiveGlasses(quantityGlasses);
            coffeeMaker.GiveCoffee(totalCoffeeNeeded);
            sugarBowl.GiveSugar(quantitySugar);

            return "Congratulations";
        }
    }
}