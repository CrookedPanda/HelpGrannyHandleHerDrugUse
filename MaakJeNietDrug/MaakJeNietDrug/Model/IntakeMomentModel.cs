using MaakJeNietDrugLogic.ClassesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaakJeNietDrugAPI.Model
{

    public class IntakeMomentModel
    {
        public int medId { get; set; }
        public string dosage { get; set; }
        public int frequency { get; set; }
        public int id { get; set; }
        public string startDate { get; set; }
        public string time { get; set; }
        public IntakeMomentModel(int medId, string dosage, int frequency, string startDate, string time)
        {
            this.medId = medId;
            this.frequency = frequency;
            this.dosage = dosage;
            this.startDate = startDate;
            this.time = time;
        }

        public IntakeMomentModel(int medId, string dosage, int frequency, string startDate, string time, int id)
        {
            this.medId = medId;
            this.frequency = frequency;
            this.dosage = dosage;
            this.startDate = startDate;
            this.time = time;
            this.id = id;
        }

        public IntakeMomentModel()
        {

        }
    }
}
