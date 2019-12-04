using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductsApplication.Data;
using ProductsApplication.Models;

namespace ProductsApplication.Pages_PagesProducts
{
    public class IndexModel : PageModel
    {
        private readonly ProductsApplication.Data.ProductsContext _context;

        public IndexModel(ProductsApplication.Data.ProductsContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
