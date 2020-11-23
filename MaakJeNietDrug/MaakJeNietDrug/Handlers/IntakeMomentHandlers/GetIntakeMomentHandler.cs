using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Model;
using System.Collections.Generic;
using System.Linq;

namespace MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers

{
    public class GetIntakeMomentHandler : IGetIntakeMomentHandler
    {
        public IntakeMoment Get(int id)
        {
            using var context = new DataBaseContext();

            return context.IntakeMoments.Find(id);
        }
        public IEnumerable<IntakeMoment> Get()
        {
            using var context = new DataBaseContext();

            return context.IntakeMoments.ToList();
        }

        public IEnumerable<IntakeMoment> GetAllByMedicineId(int id)
        {
            return new List<IntakeMoment>();
        }
    }
}
