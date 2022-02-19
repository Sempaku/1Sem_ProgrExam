using System;
//37. Составить блок-схему алгоритма нахождения в одномерном массиве одинаковых идущих подряд чисел.
namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1, 1, 2, 3, 1, 1, 1, 2 };//4
            int res = 1;
            int maxi = 0;
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    res++;
                    if(maxi < res)
                        maxi = res;
                }
                else
                    res = 1;
            }
            Console.WriteLine(maxi);
        }
    }
}
