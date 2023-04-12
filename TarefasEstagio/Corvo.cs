using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodersGrowth
{
    class Corvo
    {
        static int conversorDeBinario(string binario)
        {
            int valorDecimal = 0;
            int valorBase = 1;
            int binarioConvertido = 0;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                binarioConvertido = binario[i] - '0';
                valorDecimal += binarioConvertido * valorBase;
                valorBase *= 2;
            }

            return valorDecimal;
        }

        static void Main(string[] args)
        {

            int gritosContagem = 0;
            int valorDecimalDasPiscadas = 0;

            while (gritosContagem < 3)
            {
                string piscadasOuGritos = Console.ReadLine();
                string valorBinarioDasPiscadas = "";

                if (piscadasOuGritos == "caw caw")
                {
                    Console.WriteLine(valorDecimalDasPiscadas);
                    valorDecimalDasPiscadas = 0;
                    gritosContagem++;
                }

                for (int i = 0; i < piscadasOuGritos.Length; i++)
                {
                    switch (piscadasOuGritos[i])
                    {
                        case '-':
                            valorBinarioDasPiscadas = valorBinarioDasPiscadas.Insert(valorBinarioDasPiscadas.Length, "0");
                            break;
                        case '*':
                            valorBinarioDasPiscadas = valorBinarioDasPiscadas.Insert(valorBinarioDasPiscadas.Length, "1");
                            break;
                    }
                }

                valorDecimalDasPiscadas += conversorDeBinario(valorBinarioDasPiscadas);
            }
        }
    }
}
