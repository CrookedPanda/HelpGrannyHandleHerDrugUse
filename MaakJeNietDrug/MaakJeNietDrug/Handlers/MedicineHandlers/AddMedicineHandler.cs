using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers
{
    public class AddMedicineHandler : IAddMedicineHandler
    {
        public void Add(Medicine med)
        {
            using var context = new DataBaseContext();

            context.Medicines.Add(med);
            context.SaveChanges();
        }
    }
}
