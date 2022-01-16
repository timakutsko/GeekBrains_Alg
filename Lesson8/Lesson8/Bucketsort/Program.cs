using System;
using System.Collections.Generic;
using System.Linq;

namespace Bucketsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 4, 1, 2, 6, 7, 10, 11, 23, 45, 24, 15, 14, 22, 35, 27, 17, 3, 66 };
            //int[] array = new int[] { 3, 4, 1, 2, 6, 7, 10, 11 };
            BSort(ref array);
        }
        
        static void BSort(ref int[] arr)
        {
            int max = arr.Max();
            int min = arr.Min();
            // Решил делить на 5 бакетов. Для автоматического расчета бакетов - нужны данные о повторяющихся элементах, о диапозоне данных и их разбросе.
            // Так же для повторяющихся - лучше взять не List, а загнать в Array, чтобы их раскидывать по бакетам по условию наполнения массива.
            int buckets = arr.Length % 5 == 0 ? arr.Length / 5 : arr.Length / 5 + 1;
            int step = (max - min) % buckets == 0 ? (max - min) / buckets : (max - min) / buckets + 1;
            List<int> res = new List<int>();
            List<int>[] dataBuckets = new List<int>[buckets];
            
            int prevStep = 0;
            for (int i = 1; i <= buckets; i++)
            {
                dataBuckets[i-1] = new List<int>();
                int nextStep = step * i;
                foreach(int j in arr)
                {
                    if (j > prevStep && j <= nextStep)
                    {
                        dataBuckets[i-1].Add(j);
                    }
                }
                prevStep = nextStep;
                dataBuckets[i-1].Sort();
                res.AddRange(dataBuckets[i - 1]);
            }
            arr = res.ToArray();
        }
    }
}
