﻿namespace MaakJeNietDrugLogic.ClassesLogic
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Medicine(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Medicine()
        {
        }
    }
}
