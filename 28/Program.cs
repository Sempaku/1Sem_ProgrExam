using System;
//28. Составить блок-схему алгоритма нахождения минимума в двумерном массиве.

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            float[,] arr = new float[n,m];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++) {

                    float number = float.Parse(Console.ReadLine());
                    arr[i,j] = number;
                }
               
            }
            float minimum = arr[0,0];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (minimum > arr[i,j])
                    {
                        minimum = arr[i,j];
                    }
                }
                
            }
            Console.WriteLine(minimum);
        }

    }
}
