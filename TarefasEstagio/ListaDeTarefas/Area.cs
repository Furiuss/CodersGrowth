using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasEstagio.ListaDeTarefas
{
    class Area
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0], culture);
            double B = double.Parse(valores[1], culture);
            double C = double.Parse(valores[2], culture);
            double pi = 3.14159;

            double triangulo = A * C / 2;
            double circulo = pi * Math.Pow(C, 2);
            double trapezio = (A + B) * C / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", culture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", culture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", culture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", culture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", culture)}");
        }
    }
}
