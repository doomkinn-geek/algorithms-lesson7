using System;

namespace algorithms_lesson7
{
    class Program
    {
        const int N = 10;
        const int M = 12;

        static void Print(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write("{0}\t",a[i, j]);
                Console.Write("\r\n");
            }
        }

        static void Main(string[] args)
        {
            int[,] A = new int[N, M];
            //Print(N, M, A);
            Console.WriteLine(new string('=', 90));
            int i, j;
            for (j = 0; j < M; j++)
                A[0, j] = 1; 
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
            }

            Print(N, M, A);
        }
    }

}

