using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crud_pets.Models
{
    public class Pet
    {
        public int idPet { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string description { get; set; }

        public Pet() {}

        public Pet(int id, string Name, int Age, string Description) { 
            idPet = id;
            name = Name;
            age = Age;
            description = Description;
        }

        public Pet( string Name, int Age, string Description)
        {
            name = Name;
            age = Age;
            description = Description;
        }
    }
}