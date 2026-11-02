using MaquinaCafe;

namespace MaquinaCafeTest
{
    public class TestVaso
    {
        [Fact]
        public void ReturnTrueIfGlassesExit()
        {

            Glasses smallGlasses = new Glasses(2, 10);

            bool result = smallGlasses.HasGlasses(1);

            Assert.True(result);
        }
        [Fact]

        public void ReturnFalseIfGlassesNoExit()
        {
            Glasses smallGlasses = new Glasses(1, 10);

            bool result = smallGlasses.HasGlasses(2);

            Assert.False(result);
        }

        [Fact]

        public void SubtractTheNumberOfGlasses()
        {
            Glasses smallGlasses = new Glasses(5, 10);

            smallGlasses.GiveGlasses(1);

            Assert.Equal(4, smallGlasses.GetNumberGlasses());
        }

    }
}
