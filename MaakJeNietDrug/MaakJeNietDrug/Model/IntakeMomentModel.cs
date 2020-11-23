using MaakJeNietDrugLogic.ClassesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaakJeNietDrugAPI.Model
{

    public class IntakeMomentModel
    {
        public string dosage { get; set; }
        public int frequency { get; set; }

        public string startDate { get; set; }
        public string time { get; set; }
        public IntakeMomentModel(string dosage, int frequency, string startDate, string time)
        {
            this.frequency = frequency;
            this.dosage = dosage;
            this.startDate = startDate;
            this.time = time;
        }

        public IntakeMomentModel()
        {

        }
    }
}
