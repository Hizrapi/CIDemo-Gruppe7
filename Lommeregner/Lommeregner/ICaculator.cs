using System;
using System.Collections.Generic;
using System.Text;

namespace Lommeregner
{
    public interface ICaculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);
    }
}
