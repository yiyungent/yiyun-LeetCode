using System;
using System.Threading.Channels;

namespace 旋转矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] test = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Rotate(test);



            Console.ReadLine();
        }

        static void Rotate(int[,] matrix)
        {
            int n = 3;
            int[,] newMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newMatrix[j, n - 1 - i] = matrix[i, j];
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(newMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
