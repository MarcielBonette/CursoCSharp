﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp._2.Fundamentos
{
    internal class VariáveisEConstantes
    {
        public static void Executar()
        {
            //área da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor de Mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância Entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);



        }
    }
}
