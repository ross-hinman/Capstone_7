using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindDb_Capstone.DAL;


namespace NorthwindDb_Capstone.ViewModels
{
    public class ProductVm
    {
        public Product productName { get; set; }
        public int productId { get; set; }
    }
}