using MaakJeNietDrugAPI.Handlers.AccountHandlers;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;
using System.Linq;

namespace MaakJeNietDrugLogic.Handlers.AccountHandlers
{
    public class GetAccountHandler : IGetAccountHandler
    {
        public IEnumerable<Account> Get()
        {
            using var context = new DataBaseContext();

            return context.Accounts.ToList();
        }
    }
}