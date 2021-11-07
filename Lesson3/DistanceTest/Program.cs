using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DistanceTest;

namespace GeekBrainsAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }


    public class BechmarkClass
    {
        [Benchmark]
        public void TestFloatClass()
        {
            var p1 = new PointClass();
            p1.X = 1;
            p1.Y = 1;
            var p2 = new PointClass();
            p2.X = 10;
            p2.Y = 10;
            PointClass.PointDistanceFloat(p1, p2);
        }

        [Benchmark]
        public void TestFloatStruct()
        {
            var p1 = new PointStruct();
            p1.X = 2;
            p1.Y = 2;
            var p2 = new PointStruct();
            p2.X = 20;
            p2.Y = 20;
            PointStruct.PointDistanceFloat(p1, p2);
        }
        [Benchmark]
        public void TestDoubleStruct()
        {
            var p1 = new PointStruct();
            p1.X = 3;
            p1.Y = 3;
            var p2 = new PointStruct();
            p2.X = 30;
            p2.Y = 30;
            PointStruct.PointDistanceDouble(p1, p2);
        }
        [Benchmark]
        public void TestNoSqrtStruct()
        {
            var p1 = new PointStruct();
            p1.X = 4;
            p1.Y = 4;
            var p2 = new PointStruct();
            p2.X = 40;
            p2.Y = 40;
            PointStruct.PointDistanceNoSqrt(p1, p2);
        }
    }
}

