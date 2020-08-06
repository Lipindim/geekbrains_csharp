using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Task3
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public double GetDecimal 
        { 
            get
            {
                return ((double)this.Numerator) / this.Denominator;
            }
        }


        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new AggregateException("Знаменатель не может быть равен 0.");
            this.Numerator = numerator;
            this.Denominator = denominator;
            this.Reduce();
        }

        public void Reduce()
        {
            int gratestCommonDivisor = ExtraMath.GetGreatestCommonDevisor(Numerator, Denominator);
            this.Numerator /= gratestCommonDivisor;
            this.Denominator /= gratestCommonDivisor;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            result.Reduce();
            return result;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            result.Reduce();
            return result;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            result.Reduce();
            return result;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            Fraction result = new Fraction(numerator, denominator);
            result.Reduce();
            return result;
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public static Random random = new Random();
        public static Fraction GetRandomFraction(int maxValue)
        {
            return new Fraction(random.Next(1, maxValue), random.Next(1, maxValue));
        }
    }
}
