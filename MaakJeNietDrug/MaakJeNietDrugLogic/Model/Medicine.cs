using MaakJeNietDrugLogic.Model;
using System;
using System.Collections.Generic;

namespace MaakJeNietDrugLogic.ClassesLogic
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UID { get; set; }
        public List<IntakeMoment> intakeMoments { get; set; }

        public Medicine(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Medicine(string name, string description, string uid)
        {
            Name = name;
            Description = description;
            UID = uid;
        }
        public Medicine(int id)
        {
            Id = id;
        }
        public Medicine()
        {
            intakeMoments = new List<IntakeMoment>();
        }

        //public void SetIntakeMoments(List<DateTime> momentList, int frequency)
        //{
        //    foreach (DateTime moment in momentList)
        //    {
        //        intakeMoments.Add(new IntakeMoment(moment, frequency)
        //    }
        //}
    }
}
