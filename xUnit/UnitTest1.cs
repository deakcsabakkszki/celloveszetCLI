using celloveszetCLI;

namespace xUnit_
{
    public class UnitTest1
    {
        /*
         22; 29; 12; 23 =>29
16; 45; 87; 33; =>87
96; 49;67; 45=>96
44; 3;12; 77=>77

         */
        [Fact]
        public void Test1()
        {

            Cellovo c = new Cellovo("Teszt 1;22; 29; 12; 23");
            Assert.Equal(29, c.legnagyobb());
        }
        [Fact]
        public void Test2()
        {
            Cellovo c = new Cellovo("Teszt 2;16; 45; 87; 33");
            Assert.Equal(87, c.legnagyobb());
        }
        [Fact]
        public void Test3()
        {
            Cellovo c = new Cellovo("Teszt 3;96; 49;67; 45");
            Assert.Equal(96, c.legnagyobb());
        }
    }
}