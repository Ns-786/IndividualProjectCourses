using Xunit.Sdk;

namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void IsEvenTest()
        {
            var calculator = new MathFormulas();
            int x = 1;
            int y = 2;

            var xResult = calculator.IsEven(x);
            var yResult = calculator.IsEven(y);
            Assert.False(xResult);
            Assert.True(yResult);
        }
        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(1, 3, 1)]
        public void DiffTest(int x, int y, int expectedVlue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Diff(x, y);
            Assert.Equal(result, expectedVlue);    
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        public void AddTest(int x, int y, int expectedVlue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(result, expectedVlue);
        }

        [Theory]
        [InlineData(new int[3] { 1,2,3,}, 6)]
        [InlineData(new int[3] { -4,-6,-10}, -20)]
        public void SumTest(int[] values, int expectedvlue) 
        {
            var calculator = new MathFormulas();
            var result = calculator.Sum(values);
            Assert.Equal(result, expectedvlue);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3, }, 2)]
        [InlineData(new int[3] { -4, -6, -10 }, -6)]
        public void AverageTest(int[] values, int expectedvlue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Average(values);
            Assert.Equal(result, expectedvlue);
        }

    } 
}