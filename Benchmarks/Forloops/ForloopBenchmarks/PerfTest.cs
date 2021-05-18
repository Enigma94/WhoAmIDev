using System.Collections.Generic;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using ForloopBenchmarks.Models;

namespace ForloopBenchmarks
{
    public class PerfTest
    {
        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void For_Loop_Mappning(List<dynamic> objList)
        {
            var product = new List<Product>();

            for (int i = 0; i < objList.Count; i++)
            {
                product.Add(new Product
                {
                    Id = objList[i].Id,
                    Article = objList[i].Article
                });
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void For_Loop_Variabel(List<dynamic> objList)
        {
            for (int i = 0; i < objList.Count; i++)
            {
                var a = objList[i];
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void ForEach_Mappning(List<dynamic> objList)
        {
            var product = new List<Product>();

            foreach (var obj in objList)
            {
                product.Add(new Product
                {
                    Id = obj.Id,
                    Article = obj.Article
                });
            }
        }

        [Benchmark]
        [ArgumentsSource(nameof(ProductDataCollection))]
        public void ForEach_Variabel(List<dynamic> objList)
        {
            foreach (var obj in objList)
            {
                var a = obj;
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
