using System;

namespace Algoritmo_tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a o valor da tabuada que deseja saber: ");
            int x = int.Parse(Console.ReadLine());

            for (int z = 0; z < 11; z++){
            Console.WriteLine($"{x} x {z} = {x * z}");

            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
