using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.Handlers.MedicineHandlers
{
    public interface IGetMedicinesHandler
    {
        IEnumerable<Medicine> Get(string id);
        Medicine Get(int id);
    }
}
