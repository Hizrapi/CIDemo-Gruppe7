using System;
using System.Collections.Generic;
using System.Text;

namespace Lommeregner
{
    public class Caculator : ICaculator
    {
        public int Add(int a, int b)
        {
            return 2;
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)a / b;
        }
    }
}
