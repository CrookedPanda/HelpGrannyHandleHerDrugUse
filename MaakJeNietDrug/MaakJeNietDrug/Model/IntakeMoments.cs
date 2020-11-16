using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaakJeNietDrugAPI.Model
{
    public class IntakeMoments
    {
        public int Id { get; set; }
        public int Frequency { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
