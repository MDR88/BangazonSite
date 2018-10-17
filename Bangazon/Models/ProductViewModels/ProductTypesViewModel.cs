using Bangazon.Models;
using Bangazon.Data;
using System.Collections.Generic;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductTypesViewModel
    {
        public ProductType ProductType { get; set; }
        public List<GroupedProducts> GroupedProducts { get; internal set; }
    }
}