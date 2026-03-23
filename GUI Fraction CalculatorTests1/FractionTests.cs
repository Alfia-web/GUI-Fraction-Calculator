using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI_Fraction_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Fraction_Calculator.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var fraction = new Fraction(4, 5);
            Assert.AreEqual("4/5", fraction.Verbose());
        }

        [TestMethod()]
        public void PlusFractionTest()
        {
            var fraction1 = new Fraction(1, 5);
            var fraction2 = new Fraction(2, 5);
            Fraction result = fraction1 + fraction2;
            Assert.AreEqual("15/25", result.Verbose());
        }

        [TestMethod()]
        public void ReduceFractionTest()
        {
            var fraction1 = new Fraction(1, 5);
            var fraction2 = new Fraction(2, 5);
            Fraction result = fraction1 + fraction2;
            result = result.Reduce();
            Assert.AreEqual("3/5", result.Verbose());
        }
    }

}