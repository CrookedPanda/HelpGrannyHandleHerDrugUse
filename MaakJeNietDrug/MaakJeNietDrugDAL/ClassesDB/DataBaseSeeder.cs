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
            var entities = context.Medicines.ToList();
            if (entities.Any())
            {
                return;
            }
            else
            {
                context.Medicines.Add(new Medicine("medicijn 1", "Dit is medicijn 1", "1"));
                context.Medicines.Add(new Medicine("medicijn 2", "Dit is medicijn 2", "2"));
                context.Medicines.Add(new Medicine("medicijn 3", "Dit is medicijn 3", "3"));
                context.Medicines.Add(new Medicine("medicijn 4", "Dit is medicijn 4", "4"));
            }

            context.SaveChanges();
        }
    }
}
