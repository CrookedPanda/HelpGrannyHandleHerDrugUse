using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using Microsoft.EntityFrameworkCore;

namespace MaakJeNietDrugDAL.ClassesDB
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<IntakeMoment> IntakeMoments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Initial Catalog=MaakJeNietDrug;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
            options => options.EnableRetryOnFailure());
        }
    }
}
