using System;
//Составить блок-схему алгоритма табуляции функции y=2*x на отрезке [0..2] с шагом 0.05
namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal step = 0.05M;
            Console.WriteLine("X        Y");
            for(decimal x =0; x <=2; x += step)
            {
                decimal y = 2 * x;
                Console.WriteLine($"{x}        {y}");
            }
        }
    }
}
