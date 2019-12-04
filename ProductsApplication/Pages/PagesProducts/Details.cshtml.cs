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
    public class DetailsModel : PageModel
    {
        private readonly ProductsApplication.Data.ProductsContext _context;

        public DetailsModel(ProductsApplication.Data.ProductsContext context)
        {
            _context = context;
        }

        public Products Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
