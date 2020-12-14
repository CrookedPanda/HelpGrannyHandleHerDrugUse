using MaakJeNietDrugAPI.Model;
using MaakJeNietDrugLogic.ClassesLogic;
using MaakJeNietDrugLogic.Handlers;
using MaakJeNietDrugLogic.Handlers.MedicineHandlers;
using MaakJeNietDrugLogic.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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

        [HttpGet]
        [Route("medicine/sideeffects/{id}")]
        public async Task<List<string>> GetSideEffects(int id)
        {
            Medicine med = _getHandler.Get(id);

            return await apiCall(med);
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

        private async Task<List<String>> apiCall(Medicine med)
        {
            List<string> effects = new List<string>();

            UriBuilder builder = new UriBuilder("https://api.fda.gov/drug/event.json?");
            builder.Query = "search=patient.drug.medicinalproduct:" + med.Name + "&limit=10";

            HttpClient client = new HttpClient();
            var reponse = await client.GetAsync(builder.Uri);
            string responseBody = await reponse.Content.ReadAsStringAsync();


            foreach(Result res in JsonConvert.DeserializeObject<CallResult>(responseBody).results)
            {
                foreach (Reaction reaction in res.patient.reaction)
                {
                    string reac = reaction.reactionmeddrapt.ToLower();
                    reac = reac.First().ToString().ToUpper() + reac.Substring(1);
                    effects.Add(reac);
                    

                }
            }
            effects = effects.Distinct().ToList();
            effects.Sort();
            return effects;

        }
    }
}