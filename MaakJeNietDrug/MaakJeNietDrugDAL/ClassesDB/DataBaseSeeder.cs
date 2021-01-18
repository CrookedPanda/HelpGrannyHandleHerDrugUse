using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System;
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

            var entities2 = context.IntakeMoments.ToList();
            if (entities.Any())
            {
                return;
            }
            else
            {
                context.IntakeMoments.Add(new IntakeMoment(1, "md 1", 1, Convert.ToDateTime("01/01/2001 01:01:01")));
                context.IntakeMoments.Add(new IntakeMoment(2, "md 2", 2, Convert.ToDateTime("02/02/2002 02:02:02")));
                context.IntakeMoments.Add(new IntakeMoment(3, "md 3", 3, Convert.ToDateTime("03/03/2003 03:03:03")));
                context.IntakeMoments.Add(new IntakeMoment(4, "md 4", 4, Convert.ToDateTime("04/04/2004 04:04:04")));
            }
            context.SaveChanges();
        }
    }
}
