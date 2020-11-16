using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers


{
    public class DeleteIntakeMomentHandler : IDeleteIntakeMomentHandler
    {
        public void Delete(IntakeMoment moment)
        {
            using var context = new DataBaseContext();

            context.IntakeMoments.Remove(moment);
            context.SaveChanges();
        }
    }
}