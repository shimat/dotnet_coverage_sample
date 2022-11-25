namespace CoverageSample.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            var area = AreaCalculator.Circle(1);
            Assert.Equal(Math.PI, area, 6);
        }

        [Fact]
        public void Test2()
        {
            var area = AreaCalculator.Circle(5);
            Assert.Equal(78.5398163397, area, 6);
        }

        /*
        [Fact]
        public void Negative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                AreaCalculator.Circle(-1));
        }*/
    }
}