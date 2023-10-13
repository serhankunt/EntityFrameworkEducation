using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EntityFrameworkEducation.Models
{
    public class DenemeContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L1BOF4K\\SQLEXPRESS;Database=Database1;Integrated Security=true;TrustServerCertificate=True");
        }
        public DbSet<SimpleTable> SimpleTables { get; set; }//DbSet'in içine kodlarda tanımladığımız class olan simpletable'ı veriyoruz. Dışında yer alan SimpleTables ise databasedeki karşılığı.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
