using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar ()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int NotaTruncada = (int) nota;
            // Preciso fazer uma conversão explícita, (int) > Nota = NotaTruncada
            Console.WriteLine("NotaTruncada {0}", NotaTruncada);
            // Esse processo é conhecido como Casting ou Cast

            Console.Write("Qual é a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32 (idadeString);
            Console.WriteLine("Resultado {0}", idadeInteiro);

            Console.Write("Digite primeiro número:  ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1 {0}", numero1);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2 {0}", numero2);
        }
    }
}
