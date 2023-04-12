using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth
{
    class FormulaDeBhaskara
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] valores = Console.ReadLine().Split(' ');

            double r1, r2;

            double a = double.Parse(valores[0], culture);
            double b = double.Parse(valores[1], culture);
            double c = double.Parse(valores[2], culture);

            try
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta <= 0 || a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArithmeticException();
                }

                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"R1 = {r1.ToString("F5", culture)}");
                Console.WriteLine($"R2 = {r2.ToString("F5", culture)}");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Não é possivel calcular.");
            }
        }
    }
}
