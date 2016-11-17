using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEBGroup.Models.Product
{
    public class Index
    {
        public List<ModelProduct> AllProducts { get; set; }

        public string DisplayName { get; set; }
        public Index()
        {
            AllProducts = new List<ModelProduct>();
        }


    }


    public class ModelProduct
    {
        public string SectorName { get; set; }
        public int ProductID { get; set; }
        public string DetailsUrl { get; set; }
    }
}