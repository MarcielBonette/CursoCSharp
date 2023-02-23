using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            //A comparação de p1 == p2, vai dar false, porque são locais de memória diferente. Apesar de ter os mesmos valores atribuídos.
            Console.WriteLine(p3 == p2);
            //A comparação de p3 == p2, vai dar true, porque o P3, está referênciando o local da mesma variável que a P2!!
            
            Console.WriteLine(p1.Equals(p2));
            //O método Equals, vai comparar o endereço de memória também!! Por isso retonará falso! Para alterar, preciso criar um metodo public override bool, e alterar os valores dentro do atributo!
            //Preciso manter o Equals, e o HashCode alinhados! Se não tiver programado eles de uma forma correta, irei receber uma forma de pesquisa incerta!! 
        }
    }
}
