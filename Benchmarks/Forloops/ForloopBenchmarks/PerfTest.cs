using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ForloopBenchmarks
{
    public class PerfTest
    {
        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void For_Loop(List<dynamic> objList)
        {
            for (int i = 0; i < objList.Count; i++)
            {
                var val = objList[i];
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void For_Loop_Multi(List<dynamic> objList)
        {
            for (int i = 0; i < objList.Count; i++)
            {
                var id = objList[i].Id;
                var obj = objList[i].Article;
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void ForEach(List<dynamic> objList)
        {
            foreach (var obj in objList)
            {
                var val = obj;
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void ForEach_Multi(List<dynamic> objList)
        {
            foreach (var item in objList)
            {
                var id = item.Id;
                var obj = item.Article;
            }
        }

        public static IEnumerable<object> ProductDataCollection()
        {
            yield return DataHelper.CreateObj(100);
            yield return DataHelper.CreateObj(500);
            yield return DataHelper.CreateObj(1000);
        }
    }
}
