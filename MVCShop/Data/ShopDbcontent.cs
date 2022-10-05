using Microsoft.EntityFrameworkCore;
namespace MVCShop.Data
{
    public class ShopDbContext : DbContext
    {

        //public IConfiguration Configuration { get; }
        private string connectionString = "Data Source=XPS13\\SQLEXPRESS;Initial Catalog=MVCShop;Integrated Security=True;MultipleActiveResultSets=True";
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
            //Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(connectionString);
            }
        }
        public DbSet<Product> Products { get; set; }
    }
}
