using System;
using System.Globalization;
namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE QUALQUER VALOR: ");
            double x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            

            if ( x < 0 || x > 100)
            {
                Console.WriteLine("FORA DE INTERVALO!");
            }
            else if (x <25.00)
            {
                Console.WriteLine("INTERVALO (0,25]");
            }
            else if ( x <= 50)
            {
                Console.WriteLine("INTERVALO (25,50]");
            }
            else if (  x <= 75)
            {
                Console.WriteLine("INTERVALO (50,75]");
            }
            else 
            {
                Console.WriteLine("INTERVALO (75,100]");
            }
            

            
            
        }
    }
}
