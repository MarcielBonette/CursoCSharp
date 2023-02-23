using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudadacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
                Console.Write(saudadacao);

            Console.WriteLine("Teste".Length);

            string ValorImportante = null;
            Console.WriteLine(ValorImportante?.Length);
        }
    }
}
