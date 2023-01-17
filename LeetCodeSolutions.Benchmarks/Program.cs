
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using LeetCodeSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolution.Tests
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StrStrBenchmarks>();
        }
    }
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    
   
    public class StrStrBenchmarks
    {
        private static readonly LeetCode _leetCode = new LeetCode();
        [Benchmark]
        public int StrStr()
        {
            var haystack = "hello world";
            var needle = "world";
            return _leetCode.StrStr(haystack, needle);
        }

        [Benchmark]

        public int Divide()
        {
            int a = int.MaxValue;
            int b = 1;
            return _leetCode.Divide(a, b);
        }

        [Benchmark]

        public void NextPermutaion()
        {
            var arr = new int[] { 1, 8, 4, 5 };
            _leetCode.NextPermutation(arr);

        }
        



    }
}
