using System;
using System.Globalization;
namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O CÓDIGO DO ITEM E A QUANTIDADE");
            string[] vet = Console.ReadLine().Split(" ");
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double total = 0.0; 

            if(codigo == 1)
            {
               total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }
            else
            {
                Console.WriteLine("ITEM NÃO ENCONTRATO, DIGITE O CODIGO NOVAMENTE!");
            }

            Console.WriteLine("TOTAL: R$" + total.ToString("F2",CultureInfo.InvariantCulture));

            
        }
    }
}
