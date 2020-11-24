using MaakJeNietDrugAPI.Handlers.AccountHandlers;
using MaakJeNietDrugAPI.Model;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Handlers;
using MaakJeNietDrugLogic.Handlers.IntakeMomentHandlers;
using MaakJeNietDrugLogic.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MaakJeNietDrug.Controllers
{
    public class IntakeMomentController : ControllerBase
    {
        private readonly IGetIntakeMomentHandler _getHandler;
        private readonly IAddIntakeMomentHandler _addHandler;
        private readonly IDeleteIntakeMomentHandler _deleteHandler;
        private readonly IPutIntakeMomentHandler _putHandler;

        public IntakeMomentController(IGetIntakeMomentHandler getHandler, IAddIntakeMomentHandler addHandler, IDeleteIntakeMomentHandler deleteHandler, IPutIntakeMomentHandler putHandler)
        {
            _getHandler = getHandler;
            _addHandler = addHandler;
            _deleteHandler = deleteHandler;
            _putHandler = putHandler;
        }

        [HttpGet]
        [Route("IntakeMoment")]
        public IEnumerable<IntakeMoment> GetAll()
        {
            return _getHandler.Get();
        }

        [HttpGet]
        [Route("IntakeMoment/{id}")]
        public IntakeMoment Get(int id)
        {
            return _getHandler.Get(id);
        }

        [HttpGet]
        [Route("IntakeMoment/GetAll/{id}")]
        public IEnumerable<IntakeMoment> GetAll(int id)
        {
            return _getHandler.GetAllByMedicineId(id);
        }

        [HttpPost]
        [Route("IntakeMoment")]
        public void Add([FromBody] IntakeMomentModel moments)
        {
            IntakeMoment moment = new IntakeMoment(moments.medId, moments.dosage, moments.frequency, Convert.ToDateTime(moments.startDate + " " + moments.time));
            _addHandler.Add(moment);
        }

        [HttpDelete]
        [Route("IntakeMoment")]
        public void Delete([FromBody] IntakeMoment moment)
        {

            _deleteHandler.Delete(moment);
        }

        [HttpPut]
        [Route("IntakeMoment")]
        public void Put([FromBody] IntakeMoment med)
        {
            _putHandler.Put(med);
        }
    }
}