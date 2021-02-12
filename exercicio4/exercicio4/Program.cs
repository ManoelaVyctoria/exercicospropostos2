using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, final;

            Console.WriteLine("DIGITE A HORA INICIAL E A HORA FINAL DO JOGO: ");
            string[] vet = Console.ReadLine().Split(" ");
            inicio = int.Parse(vet[0]);
            final = int.Parse(vet[1]);

            int duracao; 

            if(inicio < final)
            {
                duracao = final - inicio; 
            }
            else
            {
                duracao = 24 - inicio + final; 
            }

            Console.WriteLine("O JOGO DUROU "+ duracao + " HORA(S)!");

        }
    }
}
