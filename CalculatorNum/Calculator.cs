using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNum
{
    public class Calculator<T> : ICalculator<T> where T : struct, IConvertible
    {
        public T Add(T a, T b)
        {
            return (T)Convert.ChangeType(Convert.ToDouble(a) + Convert.ToDouble(b), typeof(T));
        }

        public T Subtract(T a, T b)
        {
            return (T)Convert.ChangeType(Convert.ToDouble(a) - Convert.ToDouble(b), typeof(T));
        }

        public T Multiply(T a, T b)
        {
            return (T)Convert.ChangeType(Convert.ToDouble(a) * Convert.ToDouble(b), typeof(T));
        }

        public T Divide(T a, T b)
        {
            if (Convert.ToDouble(b) == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");

            return (T)Convert.ChangeType(Convert.ToDouble(a) / Convert.ToDouble(b), typeof(T));
        }

        public T Pow(T a, T power)
        {
            return (T)Convert.ChangeType(Math.Pow(Convert.ToDouble(a), Convert.ToDouble(power)), typeof(T));
        }
    }
}
