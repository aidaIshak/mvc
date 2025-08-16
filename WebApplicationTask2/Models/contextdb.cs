using Microsoft.EntityFrameworkCore;

namespace WebApplicationTask2.Models
{
    public class contextdb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=schoolmha;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        public DbSet<student> students { get; set; }
        public DbSet<department> departments { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }

}
