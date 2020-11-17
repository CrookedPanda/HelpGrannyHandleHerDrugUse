using MaakJeNietDrugLogic.ClassesLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaakJeNietDrugLogic.Model
{

    public class IntakeMoment
    {
        public int Id { get; set; }
        public DateTime Date { get;  set; }
        public int Frequency { get; set; }
        public int Dosering { get; set; }
        public int MedicineId { get; set; }

        public IntakeMoment(DateTime date, int frequency, int dosering, Medicine med)
        {
            Date = date;
            Frequency = frequency;
            Dosering = dosering;
            MedicineId = med.Id;
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
