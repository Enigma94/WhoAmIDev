using System.Collections.Generic;
using ForloopBenchmarks.Models;

namespace ForloopBenchmarks
{
    public class DataHelper
    {
        public static IEnumerable<object> CreateObj(int count)
        {
            var objl = new List<object>();
            for (int i = 0; i < count; i++)
                objl.Add(new { Id = i, Article = $"num {i}" });

            return objl;
        }

        public static IEnumerable<Product> CreateProduct(int count)
        {
            var product = new List<Product>();
            for (int i = 0; i < count; i++)
                product.Add(new Product { Id = i, Article = $"num {i}" });

            return product;
        }
    }
}
