using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers


{
    public class DeleteIntakeMomentHandler : IDeleteIntakeMomentHandler
    {
        public void Delete(int id)
        {
            using var context = new DataBaseContext();

            IntakeMoment intake = context.IntakeMoments.Find(id);
            context.IntakeMoments.Remove(intake);
            context.SaveChanges();
        }
    }
}