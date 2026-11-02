namespace MaquinaCafe
{
    public class Glasses
    {
        private int NumberGlasses;
        private int Content;

        public Glasses(int numberGlasses, int content)
        {
            NumberGlasses = numberGlasses;
            Content = content;
        }
        public void SetNumberGlasses(int numberGlasses) => NumberGlasses = numberGlasses;
        public int GetNumberGlasses() => NumberGlasses;
        public void SetContent(int content) => Content = content;
        public int GetContent()  => Content;
        public bool HasGlasses(int numberGlasses) => NumberGlasses >= numberGlasses;
        public void GiveGlasses(int numberGlasses) => NumberGlasses -= numberGlasses;
    }
}
