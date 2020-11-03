using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers
{
    public class PutMedicineHandler : IPutMedicineHandler
    {
        public void Put(Medicine med)
        {
            using var context = new DataBaseContext();

            context.Medicines.Update(med);
            context.SaveChanges();
        }
    }
}