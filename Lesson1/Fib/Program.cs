using System;

namespace Fib
{
    class Program
    {
        // Класс-тест
        public class TestCase
        {
            public int X { get; set; }
            public long Expected { get; set; }
            public string ExpectedExceptionMsg { get; set; }
        }
        // Метод теста
        static void TestNumb(TestCase testCase, bool ifRec)
        {
            try
            {
                var expNumb = Fib(testCase.X, ifRec);
                if (expNumb == testCase.Expected)
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
        // Расчет числа Фибоначчи (по индексу)
        static long Fib(int number, bool rec)
        {
            
            if (rec)
            {
                if (number > 40)
                {
                    throw new StackOverflowException("Уронишь стэк! Не больше 40 индекса.");
                }
                if(number == 0)
                {
                    return 0;
                }
                else if (number == 1)
                {
                    return 1;
                }
                else
                {
                    return Fib(number - 1, rec) + Fib(number - 2, rec);
                }
            }
            else
            {
                switch (number)
                {
                    case 0:
                        return 0;
                    case 1:
                        goto case 2;
                    case 2:
                        return 1;
                    default:
                        var fib = 0;
                        var fib1 = 1;
                        var fib2 = 1;
                        for (int i = 0; i < number - 2; i++)
                        {
                            fib = fib1 + fib2;
                            fib1 = fib2;
                            fib2 = fib;
                        }
                        return fib;
                }
            }
        }
        
        static void Main(string[] args)
        {
            // Узел тестирования
            var testCase1 = new TestCase()
            {
                X = 41,
                Expected = 0,
                ExpectedExceptionMsg = "Уронишь стэк! Не больше 40 индекса.",

            };
            var testCase2 = new TestCase()
            {
                X = 7,
                Expected = 13,
                ExpectedExceptionMsg = null,

            };
            var testCase3 = new TestCase()
            {
                X = 10,
                Expected = 55,
                ExpectedExceptionMsg = null,
            };
            var testCase4 = new TestCase()
            {
                X = 3,
                Expected = 0,
                ExpectedExceptionMsg = null,
            };
            var testCase5 = new TestCase()
            {
                X = 10,
                Expected = 0,
                ExpectedExceptionMsg = null,
            };
            var testCase6 = new TestCase()
            {
                X = 40,
                Expected = 102334155,
                ExpectedExceptionMsg = null,
            };
            Console.WriteLine("Тесты на рекусрию");
            TestNumb(testCase1, true);
            TestNumb(testCase2, true);
            TestNumb(testCase3, true);
            TestNumb(testCase4, true);
            TestNumb(testCase5, true);
            Console.WriteLine("_________________");
            Console.WriteLine("Тесты без рекусрии");
            TestNumb(testCase6, false);
            TestNumb(testCase2, false);
            TestNumb(testCase3, false);
            TestNumb(testCase4, false);
            TestNumb(testCase5, false);
            Console.WriteLine("_________________");
            // Получение числа Фибоначчи
            Console.Write("Введи индекс для поиска чсила Фибоначчи: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число Фиббоначи по рекурсии: {Fib(index, true)}");
            Console.WriteLine($"Число Фиббоначи без рекурсии: {Fib(index, false)}");
        }
    }
}
