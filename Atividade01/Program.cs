using System;
using System.Collections.Generic;
using System.Text;

namespace ATIVIDADE01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, contador = 0, numero;

            Console.WriteLine("Favor usuário, digitar quantidade de números: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; valor > i; i++)
            {
                Console.WriteLine("Favor digitar valor do número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 100)
                {
                    contador++;
                }
            }

            Console.WriteLine("Quantidade de números maiores que cem são: " + contador);

            Console.ReadKey();
        }
    }
}


