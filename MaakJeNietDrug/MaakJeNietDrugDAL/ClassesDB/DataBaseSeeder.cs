using MaakJeNietDrugLogic.ClassesLogic;
using System.Linq;

namespace MaakJeNietDrugDAL.ClassesDB
{
    public static class DataBaseSeeder
    {
        public static void SeedMedine()
        {
            using var context = new DataBaseContext();

            context.Database.EnsureCreated();

            var entities = context.Medicines.ToList();
            if (entities.Any()) return;

            context.Medicines.Add(new Medicine("Paracetamol", "Tegen de hoofdpijn"));
            context.Medicines.Add(new Medicine("Asperine", "Tegen de hoofdpijn"));

            context.SaveChanges();
        }
    }
}
