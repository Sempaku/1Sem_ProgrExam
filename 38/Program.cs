using System;

namespace _38
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 2, 0.5, 1, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        break;
                    if(arr[i] == 1 / arr[j])
                    {
                        Console.WriteLine("Взаимообратные пары = {0} / {1}",arr[i],arr[j]);
                    }
                }
            }
        }
    }
}
