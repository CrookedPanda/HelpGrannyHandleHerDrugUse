using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers
{
    public class AddIntakeMomentHandler : IAddIntakeMomentHandler
    {
        public void Add(List<IntakeMoment> moments)
        {
            using var context = new DataBaseContext();
            foreach(IntakeMoment moment in moments)
            {
                context.IntakeMoments.Add(moment);
                context.SaveChanges();
            }
        }
    }
}
