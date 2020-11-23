using MaakJeNietDrugLogic.ClassesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaakJeNietDrugLogic.Model
{

    public class IntakeMoment
    {
        public int Frequency { get; set; }
        public string Dosage { get; set; }
        public int MedicineId { get; set; }
        public DateTime startDate { get;  set; }
        public string time { get; private set; }
        public int Id { get; set; }
        public IntakeMoment(int medId, string dosage, int frequency, DateTime startDate)
        {
            MedicineId = medId;
            this.Frequency = frequency;
            this.Dosage = dosage;
            this.startDate = startDate;
        }

        public IntakeMoment()
        {

        }

        public Frequency getDay(int frequency)
        {
            return (Frequency)frequency;
        }
    }
}
