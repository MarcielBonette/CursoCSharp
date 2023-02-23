using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
            //Função OUT, só vai gerar saída! Ou seja, tudo que estiver dentro da estrutura, será chamado por referência quando eu aplicar o OUT na função.
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);
            //Quando eu coloco o "ref a" significa que estou ligando a classe com a classe de AlterarRef. Então as duas fazem uma junção, resultando em 1003.

            //int b = 2; | Posso chamar a função diretamente.
            AlterarOut(out int b, out int c);
            Console.WriteLine(b);
        }
    }
}
