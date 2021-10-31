using System;

namespace CheckNumber
{
    class Program
    {
        // Класс-тест
        public class TestCase
        {
            public int X { get; set; }
            public string Expected { get; set; }
            public string ExpectedExceptionMsg { get; set; }
        }
        // Метод теста
        static void TestNumb(TestCase testCase)
        {
            try
            {
                var expString = CheckNumber(testCase.X);
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
        // Метод поиска
        static string CheckNumber(int number)
        {
            if (number < 2)
            {
                throw new ArgumentException("Вводи числа, только больше 1!");
            }
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if (d == 0)
            {
                return "Простое число!";
            }
            else
            {
                return "Не простое число!";
            }
        }
        // Тело программы
        static void Main(string[] args)
        {
            // Узел тестирования
            var testCase1 = new TestCase()
            {
                X = 3,
                Expected = "Простое число!",
                ExpectedExceptionMsg = null,

            };
            var testCase2 = new TestCase()
            {
                X = 4,
                Expected = "Не простое число!",
                ExpectedExceptionMsg = null,

            };
            var testCase3 = new TestCase()
            {
                X = 1,
                Expected = null,
                ExpectedExceptionMsg = "Вводи числа, только больше 1!",
            };
            var testCase4 = new TestCase()
            {
                X = 4,
                Expected = "Простое число!",
                ExpectedExceptionMsg = null,
            };
            var testCase5 = new TestCase()
            {
                X = 3,
                Expected = "Не простое число!",
                ExpectedExceptionMsg = null,
            };
            var testCase6 = new TestCase()
            {
                X = 5,
                Expected = null,
                ExpectedExceptionMsg = String.Empty,
            };
            TestNumb(testCase1);
            TestNumb(testCase2);
            TestNumb(testCase3);
            TestNumb(testCase4);
            TestNumb(testCase5);
            TestNumb(testCase6);
            Console.WriteLine("_________________");

            // Узел ввода
            Console.Write("Введи число: ");
            int n = int.Parse(Console.ReadLine());

            // Основной расчет
            var output = CheckNumber(n);
            Console.WriteLine(output);
        }
    }
}
