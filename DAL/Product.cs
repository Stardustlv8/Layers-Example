using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product: ProductInterface.IProduct
    {
        public Entities.Product GetProductByID(int ID)
        {
            var Item = Products.Where(x => x.ProductID == ID).FirstOrDefault();
            return Item;
        }

        List<Entities.Product> Products = new List<Entities.Product>
        {
            new Entities.Product
            {
                ProductID = 1,
                ProductName = "Azucar",
                UnitPrice = 20,
                UnitStock = 100
            },
            new Entities.Product
            {
                ProductID = 2,
                ProductName = "Coca Cola",
                UnitPrice = 11,
                UnitStock = 100

            },
            new Entities.Product
            {
                ProductID = 3,
                ProductName = "Tortillas",
                UnitPrice = 10,
                UnitStock = 100

            }

        };
    }
}
