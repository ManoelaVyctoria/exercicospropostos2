using System;
using System.Globalization;
namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VALOr: ");
            double x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double imposto = 0.0; 

            if (x <= 2000.00)
            {
                Console.WriteLine("ISENTO");
            }
            else if (x <= 3000.00)
            {
                imposto = (x - 2000.0) * 0.08;

                Console.WriteLine(imposto);
            }
            else if (x <= 4500.00)
            {
                imposto = (x - 3000.0) * 0.18;
                Console.WriteLine(imposto);
            }
            else
            {
                imposto = (x - 4500.0) * 0.28;
                Console.WriteLine(imposto);
            }


        }
    }
}
