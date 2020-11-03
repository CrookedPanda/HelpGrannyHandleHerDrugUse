using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers


{
    public class DeleteMedicineHandler : IDeleteMedicineHandler
    {
        public void Delete(Medicine med)
        {
            using var context = new DataBaseContext();

            context.Medicines.Remove(med);
            context.SaveChanges();
        }
    }
}