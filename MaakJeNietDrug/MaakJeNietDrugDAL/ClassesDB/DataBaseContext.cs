using MaakJeNietDrugLogic.ClassesLogic;
using Microsoft.EntityFrameworkCore;

namespace MaakJeNietDrugDAL.ClassesDB
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=MaakJeNietDrug;Trusted_Connection=True;");
        }
    }
}
