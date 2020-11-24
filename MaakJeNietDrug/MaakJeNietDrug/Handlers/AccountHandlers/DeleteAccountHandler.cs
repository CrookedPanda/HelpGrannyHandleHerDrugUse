using MaakJeNietDrugAPI.Handlers.AccountHandlers;
using MaakJeNietDrugDAL.ClassesDB;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.Handlers.AccountHandlers
{
    public class DeleteAccountHandler : IDeleteAccountHandler
    {
        public void Delete(Account acc)
        {
            using var context = new DataBaseContext();

            context.Accounts.Remove(acc);
            context.SaveChanges();
        }
    }
}