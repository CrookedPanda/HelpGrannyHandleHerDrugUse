using MaakJeNietDrugLogic.ClassesLogic;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.Handlers
{
    public interface IGetMedicinesHandler
    {
        IEnumerable<Medicine> GetMedicine();
    }
}
