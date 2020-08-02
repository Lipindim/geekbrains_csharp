using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Task1
{
    public class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public Complex(double re, double im)
        {
            this.Re = re;
            this.Im = im;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            double resultRe = a.Re * b.Re - a.Im * b.Im;
            double resultIm = a.Re * b.Im + a.Im * b.Re;
            return new Complex(resultRe, resultIm);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double resultRe = (a.Re * b.Re + a.Im * b.Im) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2));
            double resultIm = (a.Im * b.Re - a.Re * b.Im) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2));
            return new Complex(resultRe, resultIm);
        }

        public override string ToString()
        {
            if (this.Im == 0)
                return this.Re.ToString();
            else
                return $"{this.Re} {(this.Im > 0 ? "+" : "-")} {Math.Abs(this.Im)}i";
        }
    }
}
