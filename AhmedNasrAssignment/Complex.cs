using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedNasrAssignment
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            int real = (c1?.Real ?? 0) + (c2?.Real ?? 0);
            int imag = (c1?.Imag ?? 0) + (c2?.Imag ?? 0);
            return new Complex(real,imag) ;

        } 
        public static Complex operator -(Complex c1, Complex c2)
        {
            int real = (c1?.Real ?? 0) - (c2?.Real ?? 0);
            int imag = (c1?.Imag ?? 0) - (c2?.Imag ?? 0);
            return new Complex(real,imag) ;

        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
