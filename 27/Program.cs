using System;
//27. Составить блок-схему алгоритма нахождения максимума в одномерном массиве
namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            for (int i = 0; i < n; i++)
            {
                float number = float.Parse(Console.ReadLine());
                arr[i] = number;
            }
            float maximum = arr[0];
            for (int step = 0; step < n; step++)
            {
                if (maximum < arr[step])
                {
                    maximum = arr[step];
                }
            }
            Console.WriteLine(maximum);
        }

    }
}
