using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;
using System.Linq;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers

{
    public class GetMedicinesHandler : IGetMedicinesHandler
    {
        public Medicine Get(int id)
        {
            using var _context = new DataBaseContext();

            return _context.Medicines.Find(id);
        }
        public IEnumerable<Medicine> Get(string id)
        {
            using var _context = new DataBaseContext();

            List<Medicine> medicines = new List<Medicine>();
            foreach(Medicine med in _context.Medicines.ToList())
            {
                if(med.UID == id)
                {
                    medicines.Add(med);
                }
            }

            return medicines;
            
        }

        public IEnumerable<Medicine> GetAll()
        {
            using var _context = new DataBaseContext();

            return _context.Medicines.ToList();
        }
    }
}
