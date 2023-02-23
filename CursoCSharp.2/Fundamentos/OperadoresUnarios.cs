using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //Ao colocar o negativo, ele inverterá o valor da operação.
            Console.WriteLine(!booleano);//Ao colocar exclamação, ele irá alterar o valor lógico "!" significa diferente

            numero1++;
            Console.WriteLine(numero1);//++ irá acrescentar (1)

            --numero1;
            Console.WriteLine(numero1);//-- tirará (1)

            Console.WriteLine(numero1++ == --numero2);
            //A prioridade de ordens, sempre será para o sinal posterior ao valor da variável. No caso, será feito primeiro a operação do "número2", por conta do sinal vir primeiro.
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
