using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        protected int a, b;
        public  ComplexNumber(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return (String.Format("({0}, {1})", this.a, this.b));
        }

        public void SetImaginary(int imagin)
        {
            this.b = imagin;
        }

        public double GetMagnitude()
        {
            return System.Math.Sqrt(Math.Pow(this.a, 2.0) + Math.Pow(this.b, 2.0));
        }

        public void Add(ComplexNumber num)
        {
            this.a += num.a;
            this.b += num.b;
           
           
        }
    }
}
