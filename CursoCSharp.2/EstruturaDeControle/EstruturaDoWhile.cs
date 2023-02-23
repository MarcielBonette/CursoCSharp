using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.EstruturaDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo! {0}", entrada);
                Console.WriteLine("Deseja Continuar?(S/N)");
                entrada = Console.ReadLine();
            }
            while (entrada.ToLower() == "s");
            Console.WriteLine("Tchau!");
        }
    }
}
