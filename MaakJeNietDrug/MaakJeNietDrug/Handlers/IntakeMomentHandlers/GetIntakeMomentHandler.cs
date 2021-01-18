using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers

{
    public class GetIntakeMomentHandler : IGetIntakeMomentHandler
    {
        public IntakeMoment Get(int id)
        {
            using var context = new DataBaseContext();

            return context.IntakeMoments.Find(id);
        }
        public IEnumerable<IntakeMoment> Get()
        {
            using var context = new DataBaseContext();

            return context.IntakeMoments.ToList();
        }

        public IEnumerable<IntakeMoment> GetAllByMedicineId(int id)
        {
            using var context = new DataBaseContext();

            List<IntakeMoment> moments = context.IntakeMoments
                .Where(o => o.MedicineId == id)
                .ToList();
            return moments;
        }

        public IEnumerable<IntakeMoment> GetAllByAccountId(string id)
        {
            using var context = new DataBaseContext();
            List<IntakeMoment> moments = new List<IntakeMoment>();
            foreach (Medicine med in context.Medicines.ToList())
            {
                if (med.UID == id)
                {
                    List<IntakeMoment> intakes = context.IntakeMoments
                        .Where(o => o.MedicineId == med.Id)
                        .ToList();
                    foreach(IntakeMoment intake in intakes)
                    {
                        moments.Add(intake);
                    }
                }
            }
            return moments;
        }
    }
}
