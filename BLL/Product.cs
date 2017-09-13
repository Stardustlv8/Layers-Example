using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Product
    {
        private DALFactory.DALProductFactory Factory;

        public Product() : this(new DALFactory.DALProductFactory())
        {
        }

        public Product(DALFactory.DALProductFactory factory)
        {
            this.Factory = factory;
        }

        public delegate void ErrorEventHandler(object sender, ErroEventArgs e);
        public event ErrorEventHandler ErrorEvent;
        public Entities.Product GetProductByID(int ID)
        {
            Entities.Product Result;
            if (ID > 0)
            {
                Factory = new DALFactory.DALProductFactory();
                var D = Factory.GetDALProduct();
                Result = D.GetProductByID(ID);
                if (Result == null && ErrorEvent != null)
                {
                    ErrorEvent?.Invoke(this, new ErroEventArgs("Producto no Encontrado"));
                }
            }
            else
            {
                ErrorEvent?.Invoke(this, new ErroEventArgs("El ID debe ser mayor que cero"));
                Result = null;
            }

            return Result;

        }

    }
}
