using Bangazon.Models.ProductTypeViewModels;
using Bangazon.Data;
using System.Collections.Generic;

namespace Bangazon.Models.ProductTypeViewModels
{
    public class ProductTypesViewModel
    {
        public ProductType ProductType { get; set; }
        public List<GroupedProducts> GroupedProducts { get; internal set; }
    }


}