using System;
//35. Составить блок-схему алгоритма нахождения количества столбцов двумерного массива, где есть хотя бы один нулевой элемент.
namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;
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
                    if(arr[i,j] == 0)
                    {
                        count++;
                        break;
                    }
                }

            }
            Console.WriteLine(count);
        }
    }
}
