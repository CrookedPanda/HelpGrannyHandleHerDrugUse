using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaakJeNietDrugAPI.Handlers.AccountHandlers;
using MaakJeNietDrugLogic.ClassesLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MaakJeNietDrug.Controllers
{ 
    public class AccountController : Controller
    {
        private readonly IGetAccountHandler _getHandler;
        private readonly IAddAccountHandler _addHandler;
        private readonly IPutAccountHandler _putHandler;
        private readonly IDeleteAccountHandler _deleteHandler;

        public AccountController(IGetAccountHandler getHandler, IAddAccountHandler addHandler, IDeleteAccountHandler deleteHandler, IPutAccountHandler putHandler)
        {
            _getHandler = getHandler;
            _addHandler = addHandler;
            _putHandler = putHandler;
            _deleteHandler = deleteHandler;
        }

        [HttpGet]
        [Route("account")]
        public IEnumerable<Account> GetAll()
        {
            return _getHandler.Get();
        }

        [HttpPost]
        [Route("account")]
        public void Add([FromBody] Account acc)
        {
            _addHandler.Add(acc);
        }

        [HttpPut]
        [Route("account")]
        public void Put([FromBody] Account acc)
        {
            _putHandler.Put(acc);
        }

        [HttpDelete]
        [Route("account")]
        public void Delete([FromBody] Account acc)
        {
            _deleteHandler.Delete(acc);
        }
    }
}

