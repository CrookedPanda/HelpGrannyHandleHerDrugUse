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
            optionsBuilder.UseMySql("server=78.47.226.85;database=s14_steven;user=u14_ESx54Duey2;password=9D9AQmyF^cpVePcD1R9zE.^g",
            options => options.EnableRetryOnFailure());
        }
    }
}
