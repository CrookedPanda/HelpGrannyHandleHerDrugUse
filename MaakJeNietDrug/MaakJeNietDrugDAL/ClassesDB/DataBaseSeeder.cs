using MaakJeNietDrugLogic.ClassesLogic;
using System.Linq;

namespace MaakJeNietDrugDAL.ClassesDB
{
    public static class DataBaseSeeder
    {
        public static void SeedMedicine()
        {
            using var context = new DataBaseContext();

            context.Database.EnsureCreated();

            context.SaveChanges();
        }
    }
}
