using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers
{
    public interface IAddIntakeMomentHandler
    {
        public void Add(List<IntakeMoment> moment);
    }
}
