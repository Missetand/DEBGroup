using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEBGroup.Models.Category
{
    public class Index
    {
        public List<ModelCategory> AllCategories { get; set; }
        public string DisplayName { get; set; }

        public Index()
        {
            AllCategories = new List<ModelCategory>();
        }
    }

    public class ModelCategory
    {
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
    }
}