﻿using System;
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
            return new DALJson.Product();
        }
    }
}
