using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs05
{
    public class Calculator
    {
        // Overloading method
        public static int Cal_sum(int a, int b)
        {
            return a + b;
        }
        public static float Cal_sum(float a, float b)
        {
            return a + b;
        }
    }
}