using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaakJeNietDrugAPI.ClassesLogic
{
    public class MedicineCollection
    {
        private List<Medicine> medicineList;

        public MedicineCollection()
        {
            medicineList = new List<Medicine>();
            int test = 3;
        }

        public void Add(Medicine med)
        {
            medicineList.Add(med);
            int count = medicineList.Count();
        }

        public void Delete(int id)
        {
            Medicine medicine = new Medicine();
            foreach (Medicine med in medicineList)
            {
                if(med.id == id)
                {
                    medicine = med;
                }
            }
            medicineList.Remove(medicine);
        }

        public List<Medicine> GetAll()
        {
            if(medicineList.Count > 0)
            {
                return medicineList;
            }
            else
            {
                return medicineList;
            }
        }

        public Medicine Get(int id)
        {
            Medicine medicine = new Medicine();
            foreach (Medicine med in medicineList)
            {
                if (med.id == id)
                {
                    medicine = med;
                }
            }

            if(medicine != null)
            {
                return medicine;
            }
            else
            {
                return null;
            }
        }


    }
}
