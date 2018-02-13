using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void EmptyString_ReturnZero()
        {
            var calc = new Calculator();
            var result = calc.Calculate("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void NullString_ReturnZero()
        {
            var calc = new Calculator();
            var result = calc.Calculate(null);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhiteSpacesString_ReturnZero()
        {
            var calc = new Calculator();
            var result = calc.Calculate("        ");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void OneNumber_ReturnNumber()
        {
            var calc = new Calculator();
            var result = calc.Calculate("2");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void OneNegativeNumber_ReturnNumber()
        {
            var calc = new Calculator();
            var result = calc.Calculate("-2");
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void TwoNumber_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("1,2");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TwoNegativeNumber_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("-1,-2");
            Assert.AreEqual(-3, result);
        }

        [Test]
        public void OnePosOneNegNumber_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("-7,2");
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void CrLfSeparators_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("-2\r\n4");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Separators_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("3\n2,-6");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void MoreThanTwoNumbers_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("-3\n7,2,-1\n3");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void CustomSeparators_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("//@\n4@-3@2");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CustomSeparators2_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("//;\n4;-3;2");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void NumeberWithMoreCifre_ReturnTheSum()
        {
            var calc = new Calculator();
            var result = calc.Calculate("-11,2,100");
            Assert.AreEqual(91, result);
        }
    }
}
