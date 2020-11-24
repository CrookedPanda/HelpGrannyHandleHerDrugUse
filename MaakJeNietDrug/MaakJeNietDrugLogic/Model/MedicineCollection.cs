using System.Collections.Generic;

namespace MaakJeNietDrugLogic.ClassesLogic
{
    public class MedicineCollection
    {
        private List<Medicine> medicineList;

        public MedicineCollection()
        {
            medicineList = new List<Medicine>();
        }

        //todo: add handler
        //public void Delete(int id)
        //{
        //    Medicine medicine = new Medicine();
        //    foreach (Medicine med in medicineList)
        //    {
        //        if(med.id == id)
        //        {
        //            medicine = med;
        //        }
        //    }
        //    medicineList.Remove(medicine);
        //}

        //todo: add handler
        //public List<Medicine> GetAll()
        //{
        //    if(medicineList.Count > 0)
        //    {
        //        return medicineList;
        //    }
        //    else
        //    {
        //        return medicineList;
        //    }
        //}

        //todo: add handler
        //public Medicine Get(int id)
        //{
        //    Medicine medicine = new Medicine();
        //    foreach (Medicine med in medicineList)
        //    {
        //        if (med.id == id)
        //        {
        //            medicine = med;
        //        }
        //    }

        //    return medicine;
        //}
    }
}
