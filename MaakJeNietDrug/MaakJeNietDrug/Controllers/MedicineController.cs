﻿using MaakJeNietDrugAPI.Model;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Handlers;
using MaakJeNietDrugLogic.Handlers.MedicineHandlers;
using MaakJeNietDrugLogic.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MaakJeNietDrug.Controllers
{
    public class MedicineController : ControllerBase
    {
        private readonly IGetMedicinesHandler _getHandler;
        private readonly IAddMedicineHandler _addHandler;
        private readonly IDeleteMedicineHandler _deleteHandler;
        private readonly IPutMedicineHandler _putHandler;

        public MedicineController(IGetMedicinesHandler getHandler, IAddMedicineHandler addHandler, IDeleteMedicineHandler deleteHandler, IPutMedicineHandler putHandler)
        {
            _getHandler = getHandler;
            _addHandler = addHandler;
            _deleteHandler = deleteHandler;
            _putHandler = putHandler;
        }

        [HttpGet]
        [Route("medicine/GetAllByAccountId/{id}")]
        public IEnumerable<Medicine> GetAllByAccountId(string id)
        {
            return _getHandler.Get(id);
        }

        [HttpGet]
        [Route("medicine/{id}")]
        public Medicine Get(int id)
        {
            return _getHandler.Get(id);
        }

        [HttpGet]
        [Route("medicine")]
        public IEnumerable<Medicine> GetAll()
        {
            return _getHandler.GetAll();
        }

        [HttpPost]
        [Route("medicine")]
        public void Add([FromBody] Medicine med)
        {
            _addHandler.Add(med);
        }

        [HttpDelete]
        [Route("medicine/{id}")]
        public void Delete(int id)
        {
            _deleteHandler.Delete(id);
        }

        [HttpPut]
        [Route("medicine")]
        public void Put([FromBody] Medicine med)
        {
            _putHandler.Put(med);
        }

    }
}