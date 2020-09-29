using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaakJeNietDrugAPI.ClassesLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaakJeNietDrug.Controllers
{
    public class MedicineController : ControllerBase
    {
        static MedicineCollection medColl = new MedicineCollection();

        [Route("Medicine/Get/{medId?}")]
        public Medicine Get(int? medId)
        {
            if (medId != null)
            {
                int id = Convert.ToInt32(medId);
                return medColl.Get(id);
            }
            else
            {
                return null;
            }

        }

        [Route("Medicine/GetAll")]
        public List<Medicine> GetAll()
        {
            return medColl.GetAll();
        }

        [Route("Medicine/Add/{name}/{description}")]
        public void Add(string name, string description)
        {
            Medicine med = new Medicine();
            foreach(Medicine i in medColl.GetAll())
            {
                med = i;
            }
            med = new Medicine(med.id + 1, name, description);
            medColl.Add(med);
        }

        [Route("Medicine/Delete/{id}")]
        public void Add(int id)
        {
            medColl.Delete(id);
        }

    }
}