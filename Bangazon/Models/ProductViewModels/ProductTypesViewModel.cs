using Bangazon.Models;
using Bangazon.Data;
using System.Collections.Generic;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductTypesViewModel
    {
        public List <GroupedProducts> GroupedProducts { get; set; }
        public List <Product> Products { get; set; }
        public List <Product> Title { get; set; }
    }


}