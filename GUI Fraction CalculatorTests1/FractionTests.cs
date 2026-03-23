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
            Assert.AreEqual("3/5", result.Reduce().Verbose());
        }

        [TestMethod()]
        public void PlusFractionTest2()
        {
            var fraction1 = new Fraction(5, 5);
            var fraction2 = new Fraction(5, 5);
            Fraction result = fraction1 + fraction2;
            Assert.AreEqual("3/5", result.Reduce().Verbose());
        }

        [TestMethod()]
        public void SubtractionFractionTest()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(1, 5);
            Fraction result = fraction1 - fraction2;
            Assert.AreEqual("1/5", result.Reduce().Verbose());
        }


        [TestMethod()]
        public void MultiplicationFractionTest()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(1, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual("2/25", result.Reduce().Verbose());
        }

        //[TestMethod()]
        //public void DivisionFractionTest()
        //{
        //    var fraction1 = new Fraction(2, 5);
        //    var fraction2 = new Fraction(1, 5);
        //    Fraction result = fraction1 / fraction2;
        //    Assert.AreEqual("2/5", result.Reduce().Verbose());
        //}
    }

}