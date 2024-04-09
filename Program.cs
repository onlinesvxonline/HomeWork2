using System;

namespace ConsoleApp1
{
    class Program 
    { 
        static void Main(string[] args)
        { 
            int[,] arr = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            
            int a = arr.GetLength(0);
            int b = arr.GetLength(1);

            int[] sort = new int[a * b];

            int c = 0;

            for (int i = 0; i < a; i++) 
            {
                for (int j = 0; j < b; j++)
                {
                    sort[c] = arr[i, j];
                    c++;
                }
            }
            Array.Sort(sort);
            c = 0;
            for (int i = 0;i < a; i++)
            {
                for (int j = 0;j < b; j++)
                {
                    arr[i, j] = sort[c];
                    c++;

                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        } 
    }
}
