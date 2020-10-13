using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using MaakJeNietDrugLogic.ClassesLogic;

namespace MaakJeNietDrugLogic.ClassesDB
{
    class DataBaseContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }
    }
}
