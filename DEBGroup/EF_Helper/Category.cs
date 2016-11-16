using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEBGroup.EF
{
    public partial class Category
    {
        public Category(string categoryname)
        {
            this.CategoryName = categoryname;
        }
    }
}