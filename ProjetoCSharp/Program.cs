using System;

namespace ProjetoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor de iterações");

            var num = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < num; i++)
            {
                try
                {
                    Console.WriteLine($"Fibonacci {i + 1} = {Fibonacci.CalculaFibonacci(i)}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
    }
}
