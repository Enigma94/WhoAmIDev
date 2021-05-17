using System;
using BenchmarkDotNet.Running;

namespace ForloopBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
