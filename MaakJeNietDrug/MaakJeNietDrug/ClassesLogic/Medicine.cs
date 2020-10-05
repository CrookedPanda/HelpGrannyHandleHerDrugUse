using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaakJeNietDrugAPI.ClassesLogic
{
    public class Medicine
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }
        public Medicine(int id, string name, string description)
        {
            this.name = name;
            this.id = id;
            this.description = description;
        }

        public Medicine()
        {

        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
