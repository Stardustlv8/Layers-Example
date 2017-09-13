using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInterface
{
    public interface IProduct
    {
        Entities.Product GetProductByID(int ID);
    }
}
