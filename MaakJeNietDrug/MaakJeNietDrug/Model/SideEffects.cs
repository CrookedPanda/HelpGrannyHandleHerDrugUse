using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaakJeNietDrugAPI.Model
{
    public class SideEffects
    {
        public List<string> reactionmeddrapt {get; set;}

        public void addEffect(string effect)
        {
            reactionmeddrapt.Add(effect);
        }
    }
}
