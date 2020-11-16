using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers
{
    public class PutIntakeMomentHandler : IPutIntakeMomentHandler
    {
        public void Put(IntakeMoment moment)
        {
            using var context = new DataBaseContext();

            context.IntakeMoments.Update(moment);
            context.SaveChanges();
        }
    }
}