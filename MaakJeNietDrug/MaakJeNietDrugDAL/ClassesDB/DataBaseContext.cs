using MaakJeNietDrugLogic.ClassesLogic;
using Microsoft.EntityFrameworkCore;

namespace MaakJeNietDrugDAL.ClassesDB
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
            "Server=mysql.beekmans.dev;Database=maakjenietdrug;Uid=maakjenietdrug;Pwd=Pwd4maakjenietdrug;",
            options => options.EnableRetryOnFailure());
        }
    }
}
