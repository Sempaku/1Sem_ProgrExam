//40. Составить блок-схему алгоритма нахождения одинаковых элементов в 2-х двумерных массивах А и В размерностью n х m. (A[i]=B[i]).
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input m");
        int m = int.Parse(Console.ReadLine());

        double[,] a = new double[n, m];
        double[,] b = new double[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Input A[{0},{1}]", i + 1, j + 1);
                double ax = double.Parse(Console.ReadLine());
                Console.Write("Input B[{0},{1}]", i + 1, j + 1);
                double bx = double.Parse(Console.ReadLine());
                a[i, j] = ax;
                b[i, j] = bx;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] == b[i, j])
                {
                    Console.WriteLine("A[{0},{1}] and B[{0},{1}] = {2}", i + 1, j + 1, a[i, j]);
                }
            }
        }

    }
}