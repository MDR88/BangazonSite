using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductTypeViewModels
{
    public class ProductTypeDetailViewModel
    {
       
        public string Label { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
