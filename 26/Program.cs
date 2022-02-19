using System;
//26. Составить блок-схему алгоритма нахождения минимума в одномерном массиве
namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            for( int i = 0; i < n; i++)
            {
                float number = float.Parse(Console.ReadLine());
                arr[i] = number;
            }
            float minimum = arr[0];
            for ( int step = 0;step < n; step++)
            {
                if(minimum > arr[step])
                {
                    minimum = arr[step];
                }
            }
            Console.WriteLine(minimum);
        }

    }
}
