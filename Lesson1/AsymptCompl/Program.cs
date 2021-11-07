using System;

namespace AsymptCompl
{
    class Program
    {
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++) // O(1) + O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) // O(1) + O(N^2)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(1) + O(N^2) * O(N)
                    {
                        int y = 0; // O(1) + O(N^2) * O(N * 2)

                        if (j != 0) // O(1) + O(N^2) * O(N * 3)
                        {
                            y = k / j;  // O(1) + O(N^2) 0* O(N * 4)
                        }

                        sum += inputArray[i] + i + k + j + y;  // O(1) + O(N^2) * O(N * 5)
                    }
                }
            }
            return sum;  // O(1) + O(5 * N^3) + O(1) => O(2 + 5N^3) => O(N^3)
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(StrangeSum(arr));
        }
    }
}
