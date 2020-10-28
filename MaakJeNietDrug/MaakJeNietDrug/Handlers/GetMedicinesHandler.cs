using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;
using System.Linq;

namespace MaakJeNietDrugLogic.Handlers
{
    public class GetMedicinesHandler : IGetMedicinesHandler
    {
        public IEnumerable<Medicine> GetMedicine()
        {
            using var context = new DataBaseContext();

            return context.Medicines.ToList();
        }
    }
}
