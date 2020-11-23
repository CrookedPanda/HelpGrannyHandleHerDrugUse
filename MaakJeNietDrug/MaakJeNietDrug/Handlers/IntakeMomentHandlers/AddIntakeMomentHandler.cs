using MaakJeNietDrugAPI.Model;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers
{
    public class AddIntakeMomentHandler : IAddIntakeMomentHandler
    {
        public void Add(IntakeMoment moment)
        {
            using var context = new DataBaseContext();

            context.IntakeMoments.Add(moment);
            context.SaveChanges();
        }
    }
}
