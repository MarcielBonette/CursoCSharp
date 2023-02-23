using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }
        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }



    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var Produto1 = new Produto("Caneta", 3.2, 0.1);

            var Produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.1, Ao alterar para "Public Static Double Desconto = 0.5, terei de chamar a classe.
            };
            Produto.Desconto = 0.5; //Preciso chamar a classe diretamente aqui, e ela será aplicada a todas as situações universalmente

            Console.WriteLine("Preço com Desconto: {0}", Produto1.CalcularDesconto());
            Console.WriteLine("Preço com Desconto: {0}", Produto2.CalcularDesconto());

            Produto.Desconto = 0.05;
            Console.WriteLine("Preço com Desconto: {0}", Produto1.CalcularDesconto());
            Console.WriteLine("Preço com Desconto: {0}", Produto2.CalcularDesconto());
        }
    }
}
