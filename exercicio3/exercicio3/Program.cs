using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a, b;

            Console.WriteLine("digite dois números: ");
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS!");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS!");
            }

          
                

        }
    }
}
