using Bangazon.Models.ProductTypeViewModels;
using Bangazon.Data;
using System.Collections.Generic;

namespace Bangazon.Models.ProductTypeViewModels
{
    public class ProductTypesViewModel
    {
        public List <GroupedProducts> GroupedProducts { get; set; }
        public List <Product> Products { get; set; }
        public List <Product> Title { get; set; }
    }


}