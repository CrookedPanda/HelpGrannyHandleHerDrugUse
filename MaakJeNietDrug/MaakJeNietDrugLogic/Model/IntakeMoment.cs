using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaakJeNietDrugLogic.Model
{

    public class IntakeMoment
    {
        public int Id { get; set; }
        public DateTime _Date { get;  set; }
        public int _Frequency { get; set; }
        [ForeignKey("MedicineId")]
        public int _MedicineId { get; set; }

        public IntakeMoment(DateTime date, int frequency, int medicineId)
        {
            _Date = date;
            _Frequency = frequency;
            _MedicineId = medicineId;
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
