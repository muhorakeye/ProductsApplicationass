using Microsoft.EntityFrameworkCore;

namespace ProductsApplication.Data
{
    public class ProductsContext: DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options): base(options){}
        public DbSet<Models.Products> Products { get; set; }
    }
}