using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bangazon.Data;

namespace Bangazon.Models.ProductViewModels
{
    public class ProductCreateViewModel
    {
        private ApplicationDbContext _context;

        public ProductCreateViewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

    }
}
