using ClassLibrary1;
using System.Linq;

namespace TestProject1
{
    public class UnitTest1
    {
       

        [Fact]
        public void TestFactorial()
        {
            Class1 class1 = new Class1();
            int result = class1.factorial(5);
            Assert.Equal(120, result);
        }

        [Fact]
        public void TestCountDigits()
        {
            Class1 class1 = new Class1();
            double result = class1.countDigits(123458);
            Assert.Equal(2, result);
        }
        [Fact]
        public void TestSquareIsWhite()
        {
            Class1 class1 = new Class1();
            bool result = class1.SquareIsWhite("a1");
            Assert.False(result);
        }
        [Fact]
        public void TestHeightChecker()
        {
            Class1 class1 = new Class1();
            int[] heights = { 1, 5, 2, 4, 3 };
            int result =class1.heightChecker(heights);
            Assert.Equal(2, result);
        }
        [Fact]
        public void JudgeCircle_ShouldReturnTrue_ForCircularPath()
        {
            Class1 class1 = new Class1();
            string moves = "UDRLUDRLUDRL";
            bool result = class1.JudgeCircle(moves);
            Assert.True(result);
        }
    }
}