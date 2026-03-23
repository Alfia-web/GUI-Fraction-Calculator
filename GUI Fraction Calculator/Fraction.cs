using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//проверка знаменатель меньеш числителя
namespace GUI_Fraction_Calculator
{
    
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public string Verbose()
        {
            return string.Format("{0}/{1}", this.numerator, this.denominator);
        }

        public static int getGCD(int numerator, int denominator)
        {
            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            while (denominator != 0 && numerator!=0)
            {
                if (numerator > denominator)
                {
                    numerator%=denominator;
                }
                else
                {
                    denominator%=numerator;
                }
            }
            return numerator+denominator;
        }

        public Fraction Reduce()
        {
            int gcd = getGCD(this.numerator, this.denominator);
            return new Fraction(this.numerator/gcd, this.denominator/gcd);
        }

        public static Fraction operator+(Fraction a, Fraction b)
        {
            var newNumerator = (a.numerator * b.denominator) + (a.denominator * b.numerator);
            var newDenominator = (a.denominator * b.denominator);
            Fraction result = new Fraction(newNumerator, newDenominator);
            return result;
        }


    }
}
