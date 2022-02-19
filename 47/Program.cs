using System;
//47. Составить блок-схему алгоритма нахождения минимума в каждой строке двумерного массива.
namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 3;
            int minimum;

            int[,] mas = {{1,2,3 },
                          {4,5,6 },
                          {7,8,9 } };
            
            for (int i = 0; i < n; i++)
            {
                minimum = mas[i, 0];
                for(int j = 0; j < m; j++)
                {
                    if (minimum > mas[i, j])
                        minimum = mas[i, j];
                    if(j == n-1)
                        Console.WriteLine(minimum);
                }
            }


        }

    }
}
