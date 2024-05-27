namespace Cloud_Development_Part_1_St10041994.Data
{
    using Cloud_Development_Part_1_St10041994.Models;
    using Microsoft.EntityFrameworkCore;

    public class KhumaloCraftDBContext : DbContext
    {
        public KhumaloCraftDBContext(DbContextOptions<KhumaloCraftDBContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


    }

    
}
