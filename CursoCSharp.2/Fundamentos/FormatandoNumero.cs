using System;
using System.Globalization;

namespace CursoCSharp._2.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            // O prórpio sistema irá aredondar o valor (15.2)
            Console.WriteLine(valor.ToString("C"));
            // "C" Significa valor monetário
            Console.WriteLine(valor.ToString("P"));
            // "P" Valor percentual 15.175 * 100 
            Console.WriteLine(valor.ToString("#.##"));
            // "#" Faço um requerimento para um valor que tenha duas casa decimais (15,18). Tambem poderia ter usado o comando de "F2"

            CultureInfo cultura = new CultureInfo("en-US");
            // Se eu quiser selecionar o país de conversão, tenho que fazer o System.Globalization; > CultureInfo
            Console.WriteLine(valor.ToString("C0" + cultura));
            // "C0" Significa valor sem casa decimal

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
