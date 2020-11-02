using MaakJeNietDrugAPI.Handlers.AccountHandlers;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.Handlers.AccountHandlers
{
    public class PutAccountHandler : IPutAccountHandler
    {
        public void Put(Account acc)
        {
            using var context = new DataBaseContext();

            context.Accounts.Update(acc);
            context.SaveChanges();
        }
    }
}
