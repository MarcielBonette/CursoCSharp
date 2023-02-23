using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Carlos";
            alunos[2] = "Daniela";
            alunos[3] = "Emanuel";
            alunos[4] = "Beatriz";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for(int i = 0; i < alunos.Length; i++)
            //{
            //    somatorio += notas[i];
            //}  

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A' , 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
