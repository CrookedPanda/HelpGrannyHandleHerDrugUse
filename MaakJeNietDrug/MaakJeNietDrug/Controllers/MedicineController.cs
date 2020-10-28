using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Handlers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MaakJeNietDrug.Controllers
{
    public class MedicineController : ControllerBase
    {
        private readonly IGetMedicinesHandler _getHandler;
        private readonly IAddMedicineHandler _addHandler;

        public MedicineController(IGetMedicinesHandler getHandler, IAddMedicineHandler addHandler)
        {
            _getHandler = getHandler;
            _addHandler = addHandler;
        }

        [HttpGet]
        [Route("medicine")]
        public IEnumerable<Medicine> GetAll()
        {
            return _getHandler.GetMedicine();
        }

        [HttpPost]
        [Route("medicine")]
        public void Add([FromBody] Medicine med)
        {
            _addHandler.Add(med);
        }

        //[HttpGet]
        //[Route("medicine/{id}")]
        //public Medicine Get(int id)
        //{
        //    //return medColl.GetMedine(id);
        //}

        //[HttpDelete]
        //[Route("medicine/{id}")]
        //public void Add(int id)
        //{
        //    medColl.Delete(id);
        //}
    }
}