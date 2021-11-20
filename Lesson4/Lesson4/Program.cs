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

            var hsCl = new HashSetStr();
            hsCl.GenHS(random, 3);
            var res2 = hsCl.Equals("TEST");
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
            var hsCl = new HashSetStr();
            hsCl.GenHS(random, 1000);
            var res2 = hsCl.Equals("TEST");
        }
    }
    /*
    */
}
