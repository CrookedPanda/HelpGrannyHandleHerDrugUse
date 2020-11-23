using MaakJeNietDrugAPI.Model;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers
{
    public class AddIntakeMomentHandler : IAddIntakeMomentHandler
    {
        public void Add(IntakeMoment momentModel)
        {
            using var context = new DataBaseContext();
        }
    }
}
