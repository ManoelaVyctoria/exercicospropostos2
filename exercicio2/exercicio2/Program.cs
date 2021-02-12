using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UM NÚMERO: ");
            int x = int.Parse(Console.ReadLine());

            if (x  % 2 == 0 )
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
