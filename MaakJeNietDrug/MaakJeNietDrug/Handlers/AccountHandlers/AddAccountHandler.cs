using MaakJeNietDrugAPI.Handlers.AccountHandlers;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.Handlers.AccountHandlers
{
    public class AddAccountHandler : IAddAccountHandler
    {
        public void Add(Account acc)
        {
            using var context = new DataBaseContext();

            context.Accounts.Add(acc);
            context.SaveChanges();
        }
    }
}