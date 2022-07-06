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
            for (int i = 0; i<=100; i+=2)
                Console.WriteLine($"number: {i}");
            Console.ReadKey();
        }
    }
}
