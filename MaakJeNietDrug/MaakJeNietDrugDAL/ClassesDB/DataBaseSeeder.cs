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
                context.Medicines.Add(new Medicine("medicijn 1", "Dit is medicijn 1"));
                context.Medicines.Add(new Medicine("medicijn 2", "Dit is medicijn 2"));
                context.Medicines.Add(new Medicine("medicijn 3", "Dit is medicijn 3"));
                context.Medicines.Add(new Medicine("medicijn 4", "Dit is medicijn 4"));

                context.Accounts.Add(new Account("account 1", "wachtwoord 1", "account1@hotmail.com"));
                context.Accounts.Add(new Account("account 2", "wachtwoord 2", "account2@hotmail.com"));
                context.Accounts.Add(new Account("account 3", "wachtwoord 3", "account3hotmail.com"));
                context.Accounts.Add(new Account("account 4", "wachtwoord 4", "account4@hotmail.com"));
            }

            context.SaveChanges();
        }
    }
}
