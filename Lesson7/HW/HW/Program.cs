using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ширина поля: ");
            if (Int32.TryParse(Console.ReadLine(), out int M)) ;
            Console.Write("Высота поля: ");
            if (Int32.TryParse(Console.ReadLine(), out int N)) ; 

            int[,] MN = new int[M+1,N+1];
            
            for(int m = 1; m <= M; m++)
            {
                MN[m, 1] = 1;
            }
            for(int n = 2; n <= N; n++)
            {
                MN[1, n] = 1;
                for(int m = 2; m <= M; m++)
                {
                    MN[m, n] = MN[m, n - 1] + MN[m - 1, n];
                }
            }

            Console.WriteLine(new string('\uFF3F', Console.WindowWidth));
            Console.WriteLine("Матрица:");
            for(int i = 1; i <= M; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    Console.Write(MN[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\r\n");
            }
            Console.WriteLine(new string('\uFF3F', Console.WindowWidth));

            Console.WriteLine($"Количество проходов: {MN[M, N]}");
        }
    }
}
