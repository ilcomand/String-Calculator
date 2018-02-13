using ClassLibrary1;
using NUnit.Framework;

namespace CoreTests
{
    [TestFixture]
    public class NewTests
    {
        [TestCase("")]
        [TestCase("   ")]
        [TestCase(null)]
        public void Add_EmptyString_Return(string numbers)
        {
            var sc = new Calculator();
            int actual = sc.Calculate(numbers);
            Assert.AreEqual(0, actual);
        }

        [TestCase("1", ExpectedResult = 1)]
        [TestCase("302", ExpectedResult = 302)]
        [TestCase("-5", ExpectedResult = -5)]
        public int Add_SingleNumber_ReturnTheNumber(string numbers)
        {
            var sc = new Calculator();
            int actual = sc.Calculate(numbers);
            return actual;
        }

        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("302,2567", ExpectedResult = 2869)]
        [TestCase("3,-2", ExpectedResult = 1)]
        [TestCase("-3,-2", ExpectedResult = -5)]
        [TestCase("-3,2", ExpectedResult = -1)]
        public int Add_TwoNumbers_ReturnTheSum(string numbers)
        {
            var sc = new Calculator();
            int actual = sc.Calculate(numbers);
            return actual;
        }

        [TestCase("1,2,3,4,5", ExpectedResult = 15)]
        public int Add_MoreThanTwoNumbers_ReturnTheSum(string numbers)
        {
            var sc = new Calculator();
            int actual = sc.Calculate(numbers);
            return actual;
        }

        [TestCase("1\n2", ExpectedResult = 3)]
        [TestCase("1\n2,3", ExpectedResult = 6)]
        public int Add_WhenNewLineIsSeparator_ReturnTheSum(string numbers)
        {
            var sc = new Calculator();
            int actual = sc.Calculate(numbers);
            return actual;
        }

        [TestCase("//;\n1;2", ExpectedResult = 3)]
        [TestCase("//@\n1@2@3@4@5", ExpectedResult = 15)]
        public int Add_WhenUsingCustomDelimeter_ReturnTheSum(string numbers)
        {
            var sc = new Calculator();
            int actual = sc.Calculate(numbers);
            return actual;
        }
    }
}

