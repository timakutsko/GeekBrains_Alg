using System;

namespace BinarySearch
{
    class Program
    {
        // Класс-тест
        public class TestCase
        {
            public int[] X { get; set; }
            public int Y { get; set; }
            public int Expected { get; set; }
            public string ExpectedExceptionMsg { get; set; }
        }
        // Метод теста
        static void TestNumb(TestCase testCase)
        {
            try
            {
                var expString = BinarySearch(testCase.X, testCase.Y);
                if (expString == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception exc)
            {
                if (testCase.ExpectedExceptionMsg == exc.Message)
                {

                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        // Метод поиска индекса
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;    // O(1)
            int max = inputArray.Length - 1;    // O(1) + O(1)
            while (min <= max)    // O(1) + O(1) + O((N/2)^x)
            {
                int mid = (min + max) / 2;    // O(1) + O(1) + O((N/2)^x * 2)
                if (searchValue == inputArray[mid])    // O(1) + O(1) + O((N/2)^x * 3)
                {
                    return mid;    // O(1) + O(1) + O((N/2)^x * 3) + O(1)
                }
                else if (searchValue < inputArray[mid])    // O(1) + O(1) + O((N/2)^x * 4)
                {
                    max = mid - 1;    // O(1) + O(1) + O((N/2)^x * 5)
                }
                else
                {
                    min = mid + 1;    // O(1) + O(1) + O((N/2)^x * 6)
                }
            }
            return -1;    // O(1) + O(1) + O((N/2)^x * 6) + O(1) => O((N)^x) => O(log(N))
        }
        
        static void Main(string[] args)
        {
            // Узел тестирования
            var testCase1 = new TestCase()
            {
                X = new int[] { 1, 2, 3, 4, 5 },
                Y = 5,
                Expected = 4,
                ExpectedExceptionMsg = null,

            };
            var testCase2 = new TestCase()
            {
                X = new int[] { 1, 2, 3, 4, 5 },
                Y = 2,
                Expected = 1,
                ExpectedExceptionMsg = null

            };
            var testCase3 = new TestCase()
            {
                X = new int[] { 1, 2, 3, 4, 5 },
                Y = 6,
                Expected = -1,
                ExpectedExceptionMsg = "Вне диапозона!" 
            };
            var testCase4 = new TestCase()
            {
                X = new int[] { 1, 2, 3, 4, 5 },
                Y = 2,
                Expected = 3,
                ExpectedExceptionMsg = null
            };
            var testCase5 = new TestCase()
            {
                X = new int[] { 1, 2, 3, 4, 5 },
                Y = 1,
                Expected = -1,
                ExpectedExceptionMsg = "Вне диапозона!"
            };
            TestNumb(testCase1);
            TestNumb(testCase2);
            TestNumb(testCase3);
            TestNumb(testCase4);
            TestNumb(testCase5);
            Console.WriteLine("_________________");
            // Работа алгоритма
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 14, 15, 17, 19, 123, 234, };
            Console.WriteLine(BinarySearch(arr, 2));
        }

    }
}
