using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int TamanhoTurma);

            for (int i = 1; i <= TamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = TamanhoTurma > 0 ? somatorio / TamanhoTurma : 0;
            Console.WriteLine("Média da turma {0}", media);
        }
    }
}
