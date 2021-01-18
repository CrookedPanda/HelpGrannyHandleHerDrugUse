using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers


{
    public class DeleteMedicineHandler : IDeleteMedicineHandler
    {
        public void Delete(int id)
        {
            using var context = new DataBaseContext();

            Medicine med = context.Medicines.Find(id);
            context.Medicines.Remove(med);
            context.SaveChanges();
        }
    }
}