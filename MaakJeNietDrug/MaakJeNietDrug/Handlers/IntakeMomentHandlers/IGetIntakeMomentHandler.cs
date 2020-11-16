using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers
{
    public interface IGetIntakeMomentHandler
    {
        IEnumerable<IntakeMoment> Get();
        IEnumerable<IntakeMoment> GetAllByMedicineId(int id);
        IntakeMoment Get(int id);
    }
}
