using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALFactory
{
    public class DALProductFactory
    {
        public ProductInterface.IProduct GetDALProduct()
        {
            ProductInterface.IProduct Product = null;

            var AssemblyPath = System.Configuration
                .ConfigurationManager
                .AppSettings["Product"];

            var AssemblyObject = System.Reflection
                .Assembly
                .LoadFrom(AssemblyPath);

            var ProductType = AssemblyObject
                .GetTypes()
                .Where(T => typeof(ProductInterface.IProduct)
                .IsAssignableFrom(T))
                .FirstOrDefault();
            if (ProductType != null)
            {
                Product = AssemblyObject
                    .CreateInstance(ProductType.FullName) as ProductInterface.IProduct;
            }

            return Product;
        }
    }
}
