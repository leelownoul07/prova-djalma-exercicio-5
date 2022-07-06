using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_djalma_exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numeros pares de 1 a 100");
            for (int i = 1; i <= 100; i ++)
                if (i % 2 == 0)
                {
                    Console.WriteLine($"numeros: {i}");

                }
                    
                
            Console.ReadKey();
        }
    }
}
