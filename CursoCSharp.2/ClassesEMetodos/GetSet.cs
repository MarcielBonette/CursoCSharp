using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.ClassesEMetodos
{
    internal class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            public Moto(string marca, string modelo, uint cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }
            public Moto()
            {

            }
            
            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }
            public string GetModelo()
            {
                return Modelo;
            }
            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }
            public uint GetCilindrada()
            {
                return Cilindrada;
            }
            public void SetCilindrada(uint cilindrada)
            {
                //if (cilindrada > 0)
                //{
                //    Cilindrada = cilindrada;  }
/*                Cilindrada = Math.Abs(cilindrada);*/ //Math.abs Transforma os valores negativos, em positivos!
                Cilindrada = cilindrada;
            }
        }

        public static void Executar()
        {
            var Moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(Moto1.GetMarca());
            Console.WriteLine(Moto1.GetModelo());
            Console.WriteLine(Moto1.GetCilindrada());

            var Moto2 = new Moto();
            Moto2.SetMarca("Honda");
            Moto2.SetModelo("Hornet");
            Moto2.SetCilindrada(600);
            Console.WriteLine(Moto2.GetMarca() + " " + Moto2.GetModelo() + " " + Moto2.GetCilindrada());
        }
    }
}
