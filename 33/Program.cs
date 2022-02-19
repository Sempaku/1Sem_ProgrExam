using System;
//33. Составить блок-схему алгоритма нахождения произведения всех троек в двумерном массиве.
namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            float result = 1;
            float[,] arr = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    float number = float.Parse(Console.ReadLine());
                    arr[i, j] = number;
                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] == 3)
                    {
                        count++;
                        result *= 3;
                    }
                }

            }
            if (count != 0)
                Console.WriteLine(result);
            else
                Console.WriteLine(0);

        }
    }
}
