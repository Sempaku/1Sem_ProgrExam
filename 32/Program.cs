using System;
//32. Составить блок-схему алгоритма нахождения количества цифр “5” в введенном одномерном массиве.
namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            for(int step = 0; step < n; step++)
            {
                if(arr[step] == 5)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
