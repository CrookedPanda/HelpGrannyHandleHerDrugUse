using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;
using System.Linq;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers

{
    public class GetMedicinesHandler : IGetMedicinesHandler
    {
        DataBaseContext _context;

        public GetMedicinesHandler(DataBaseContext context)
        {
            _context = context;
        }
        public Medicine Get(int id)
        {

            return _context.Medicines.Find(id);
        }
        public IEnumerable<Medicine> Get(string id)
        {
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

            return _context.Medicines.ToList();
        }
    }
}
