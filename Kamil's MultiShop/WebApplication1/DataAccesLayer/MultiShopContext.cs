

using Microsoft.EntityFrameworkCore;

using WebApplication1.Areas.Admin.Models;

using WebApplication1.Models;

namespace WebApplication1.DataAccesLayer
{
    public class MultiShopContext : DbContext
    {
        public MultiShopContext(DbContextOptions options) : base(options)
        {
        }
    
        public DbSet<Category> Categories { get; set; }
     
        public DbSet<Sliders> Sliders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("CA-R214-PC19\\SQLEXPRESS;Database=MultiShop;Trusted_Connection=true;TrustServerCertificate=True");
            base.OnConfiguring(options);
        }
    }
}
