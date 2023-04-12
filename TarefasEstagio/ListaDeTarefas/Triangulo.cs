using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasEstagio.ListaDeTarefas
{
    class Triangulo
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] valores = Console.ReadLine().Split(' ');

            double a, b, c, perimetro, area;

            a = double.Parse(valores[0], culture);
            b = double.Parse(valores[1], culture);
            c = double.Parse(valores[2], culture);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", culture)}");
            }
            else
            {
                area = (a + b) * c / 2;
                Console.WriteLine($"Area = {area.ToString("F1", culture)}");
            }
        }
    }
}
