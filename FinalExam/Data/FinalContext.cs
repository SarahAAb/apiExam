using Microsoft.EntityFrameworkCore;

namespace FinalExam.Data
{
    public class FinalContext:DbContext
    {
        IConfiguration configuration;

         public FinalContext(IConfiguration _configuration) {
            configuration = _configuration;
        }
        public DbSet<Country> countries { get; set; }
        public DbSet<City> cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Final"));
        }
    }
}
