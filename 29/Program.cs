using System;
//29.Составить блок - схему алгоритма нахождения максимума в двумерном массиве.

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            float[,] arr = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    float number = float.Parse(Console.ReadLine());
                    arr[i, j] = number;
                }

            }
            float maximum = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (maximum < arr[i, j])
                    {
                        maximum = arr[i, j];
                    }
                }

            }
            Console.WriteLine(maximum);
        }

    }
}
