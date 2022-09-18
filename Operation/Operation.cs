using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    public class Operation
    {
        decimal val1;
        decimal val2;

        public decimal Suma(string num1, string num2)
        {
            val1 = decimal.Parse(num1);
            val2 = decimal.Parse(num2);

            return val1 + val2;
        }

        public decimal Resta(string num1, string num2)
        {
            val1 = int.Parse(num1);
            val2 = int.Parse(num2);

            return val1 - val2;
        }

        public decimal Multiplicar(string num1, string num2)
        {
            val1 = int.Parse(num1);
            val2 = int.Parse(num2);

            return val1 * val2;
        }

        public decimal Dividir(string num1, string num2)
        {
            val1 = int.Parse(num1);
            val2 = int.Parse(num2);

            return val1 / val2;
        }
    }
}
