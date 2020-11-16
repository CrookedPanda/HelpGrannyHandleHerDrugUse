using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;
using System.Linq;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers

{
    public class GetMedicinesHandler : IGetMedicinesHandler
    {
        public IEnumerable<Medicine> Get()
        {
            using var context = new DataBaseContext();

            return context.Medicines.ToList();
        }
        public Medicine Get(int id)
        {
            using var context = new DataBaseContext();

            return context.Medicines.Find(id);
        }
    }
}
