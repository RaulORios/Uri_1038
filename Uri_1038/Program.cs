using System;
using System.Globalization;

namespace Uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int qtde = int.Parse(vet[1]);

            double total;
            
            if (codigo == 1)
            {
                total = qtde * 4.0;
            }
            else if (codigo == 2)
            {
                total = qtde * 4.5;
            }
            else if (codigo == 3)
            {
                total = qtde * 5.0;
            }
            else if (codigo == 4)
            {
                total = qtde * 2.0;
            }
            else 
            {
                total = qtde * 1.5;
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
