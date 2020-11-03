using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;

namespace MaakJeNietDrugAPI.Handlers.AccountHandlers
{
    public interface IGetAccountHandler
    {
        public IEnumerable<Account> Get();
    }
}
