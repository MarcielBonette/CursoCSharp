using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int NumeroSecreto = random.Next(1, 16);
            bool NumeroEncontrado = false;
            int TentativasRestantes = 5;
            int TentativasAtuais = 0;

            while(TentativasRestantes > 0 && !NumeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                TentativasAtuais++;
                TentativasRestantes--;

                if(NumeroSecreto == palpite)
                {
                    NumeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero Encontrado em {0} tentativas", TentativasAtuais);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > NumeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", TentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", TentativasRestantes);
                }
            }
        }
    }
}
