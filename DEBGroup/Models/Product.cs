using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEBGroup.EF
{
    public partial class Product
    {
        public Product(string productname)
        {
            this.ProductName = productname;
        }
    }
}