using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Test;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random random = new Random();
            var arrCl = new ArrClass();
            arrCl.GenArr(random, 3);
            var res1 = arrCl.IsInsert("TEST");

            var hashSet = new HashSet<HashSetStr>();
            var gener = new WordGen();
            for (int i = 0; i < 3; i++)
            {
                string word = gener.GenString(random);
                var hss = new HashSetStr();
                hss.RandString = word;
                hashSet.Add(hss);
            }
            var checkStr = new HashSetStr() { RandString = "TEST" };
            hashSet.Add(checkStr);
            var res2 = hashSet.Contains(checkStr);
            */
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BenchmarkClass
    {
        [Benchmark]
        public void TestArray()
        {
            Random random = new Random();
            var arrCl = new ArrClass();
            arrCl.GenArr(random, 1000);
            var res1 = arrCl.IsInsert("TEST");
        }

        [Benchmark]
        public void TestHashSet()
        {
            Random random = new Random();
            var hashSet = new HashSet<HashSetStr>();
            var gener = new WordGen();
            for (int i = 0; i < 1000; i++)
            {
                var hss = new HashSetStr();
                string word = gener.GenString(random);
                hss.RandString = word;
                hashSet.Add(hss);
            }
            var checkStr = new HashSetStr() { RandString = "TEST" };
            hashSet.Add(checkStr);
            var res2 = hashSet.Contains(checkStr);
        }
    }
}
