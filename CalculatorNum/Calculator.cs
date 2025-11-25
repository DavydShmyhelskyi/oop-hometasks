using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNum
{
    public class Calculator<T> : ICalculator<T> where T : INumber<T>
    {
        
        private static T One() => T.One;
        private static T Zero() => T.Zero;

        public T Add(T a, T b)
        {
            return a+b;
        }

        public T Subtract(T a, T b)
        {
            return a-b;
        }

        public T Multiply(T a, T b)
        {
            return a*b;
        }

        public T Divide(T a, T b)
        {
            if (Convert.ToDouble(b) == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");

            return a/b;
        }

        public T Pow(T a, T power)
        {
            T result = One();     
            T i = Zero();        

            while (i< power)
            {
                result = Multiply(result, a);
                i = Add(i, One());
            }

            return result;
        }

        private double NaturalLog(double a)
        {
            double y = (a - 1) / (a + 1);
            double y2 = y * y;

            double sum = 0;
            double term = y;
            int k = 1;

            for (int i = 0; i < 30; i++)
            {
                sum += term / k;
                term *= y2;
                k += 2;
            }

            return 2 * sum;
        }

        private double Exp(double x)
        {
            double sum = 1.0;
            double term = 1.0;

            for (int i = 1; i <= 30; i++)
            {
                term *= x / i;
                sum += term;
            }

            return sum;
        }
    }
}
