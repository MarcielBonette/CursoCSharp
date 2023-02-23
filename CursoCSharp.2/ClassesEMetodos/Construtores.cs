using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.ClassesEMetodos
{
    class carro
    {
       public string Modelo;
       public string Fabricante;
       public int Ano;

        public carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public carro() { }

    }



    internal class Construtores
    {
        public static void Executar()
        {
            var carro1 = new carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new carro("M8 Coupé", "BMW", 2022);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            var carro3 = new carro()
            {
                Fabricante = "Mercedes",
                Modelo = "C 300 AMG",
                Ano = 2017
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
