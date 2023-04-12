using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasEstagio.ListaDeTarefas
{
    public class SalarioComBonus
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");

            string name = Console.ReadLine();
            double fixedSalary = double.Parse(Console.ReadLine(), culture);
            double salesAmount = double.Parse(Console.ReadLine(), culture);

            double bonus = 0.15 * salesAmount;
            double total = fixedSalary + bonus;

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", culture)}");
        }
    }
}
