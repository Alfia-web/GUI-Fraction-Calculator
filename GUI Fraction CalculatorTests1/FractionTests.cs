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
        public void PlusFractionTest()
        {
            var fraction1 = new Fraction(1, 5);
            var fraction2 = new Fraction(2, 5);
            Fraction result = fraction1 + fraction2;
            Assert.AreEqual(new Fraction(3, 5), result);
        }

        [TestMethod()]
        public void PlusFractionTest2()
        {
            var fraction1 = new Fraction(5, 5);
            var fraction2 = new Fraction(5, 5);
            Fraction result = fraction1 + fraction2;
            Assert.AreEqual(new Fraction(2, 1), result);
        }

        [TestMethod()]
        public void PlusDifferentDenominator()
        {
            var result = new Fraction(1, 3) + new Fraction(1, 4);
            Assert.AreEqual(new Fraction(7, 12), result);
        }

        [TestMethod()]
        public void PlusWithZeroNumerator()
        {
            var result = new Fraction(1,5) + new Fraction(0, 4);
            Assert.AreEqual(new Fraction(1, 5), result);
        }

        [TestMethod()]
        public void PlusBothNegative()
        {
            var result = new Fraction(-1, 5) + new Fraction(-2, 5);
            Assert.AreEqual(new Fraction(- 3, 5), result);
        }

        [TestMethod()]
        public void SubtractionNegative()
        {
            var fraction1 = new Fraction(1, 5);
            var fraction2 = new Fraction(2, 5);
            Fraction result = fraction1 - fraction2;
            Assert.AreEqual(new Fraction(-1, 5), result);
        }

        [TestMethod()]
        public void SubtractionZeroResult()
        {
            var fraction1 = new Fraction(1, 5);
            var fraction2 = new Fraction(1, 5);
            Fraction result = fraction1 - fraction2;
            Assert.AreEqual(new Fraction(0, 1), result);
        }

        [TestMethod()]
        public void SubtractionBothNegative()
        {
            var fraction1 = new Fraction(-2, 5);
            var fraction2 = new Fraction(-1, 5);
            Fraction result = fraction1 - fraction2;
            Assert.AreEqual(new Fraction(-1, 5), result);
        }

        [TestMethod()]
        public void MultiplicationFractionTest()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(1, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual(new Fraction(2, 25), result);
        }

        [TestMethod()]
        public void MultiplicationBothNegative()
        {
            var fraction1 = new Fraction(-2, 5);
            var fraction2 = new Fraction(-1, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual(new Fraction(2, 25), result);
        }


        [TestMethod()]
        public void MultiplicationOneNegative()
        {
            var fraction1 = new Fraction(-2, 5);
            var fraction2 = new Fraction(1, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual(new Fraction(-2, 25), result);
        }

        [TestMethod()]
        public void MultiplicationWithZero()
        {
            var fraction1 = new Fraction(-2, 5);
            var fraction2 = new Fraction(0, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual(new Fraction(0, 1), result);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(1, 2);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual(new Fraction(1, 2), result);
        }

        [TestMethod()]
        public void DivisionNegative()
        {
            var fraction1 = new Fraction(-2, 5);
            var fraction2 = new Fraction(1, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual(new Fraction(-2, 1), result);
        }

        [TestMethod()]
        public void CompareLeftBigger()
        {
            var fraction1 = new Fraction(3, 5);
            var fraction2 = new Fraction(1, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual("3/5 больше, чем 1/5", Fraction.Compare(fraction1, fraction2));
        }

        [TestMethod()]
        public void CompareRightBigger()
        {
            var fraction1 = new Fraction(3, 5);
            var fraction2 = new Fraction(6, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual("6/5 больше, чем 3/5", Fraction.Compare(fraction1, fraction2));
        }

        [TestMethod()]
        public void CompareEqual()
        {
            var fraction1 = new Fraction(3, 5);
            var fraction2 = new Fraction(3, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual("Ну они раавны", Fraction.Compare(fraction1, fraction2));
        }

        [TestMethod()]
        public void CompareOneNegative()
        {
            var fraction1 = new Fraction(3, 5);
            var fraction2 = new Fraction(-6, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual("3/5 больше, чем -6/5", Fraction.Compare(fraction1, fraction2));
        }

        [TestMethod()]
        public void CompareBothNegative()
        {
            var fraction1 = new Fraction(-3, 5);
            var fraction2 = new Fraction(-6, 5);
            Fraction result = fraction1 * fraction2;
            Assert.AreEqual("-3/5 больше, чем -6/5", Fraction.Compare(fraction1, fraction2));
        }
    }

}