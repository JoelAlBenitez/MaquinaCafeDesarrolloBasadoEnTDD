namespace MaquinaCafe
{
    public class SugarBowl
    {
        private int QuantitySugar;

        public SugarBowl(int quantitySugar) {
        
            QuantitySugar = quantitySugar;
        }

        public void SetQuantitySugar(int quantitySugar)  => QuantitySugar = quantitySugar;
        public int GetQuantitySugar() => QuantitySugar;
        public bool HasSugar(int quantity)  => QuantitySugar >= quantity;
        public void GiveSugar(int quantity)  => QuantitySugar -= quantity;
    }
}
