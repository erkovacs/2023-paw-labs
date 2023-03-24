using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoLabWinFormsApp.Entities
{
    internal enum Species
    {
        None,
        Chimpanzee,
        Elephant,
        Lion,
        Tiger,
        Zebra
    }
    internal class Animal
    {
        public int Id { get; private set; }
        public Species Species { get; private set; }
        public string Name { get; set; }

        public Animal() { }
        public Animal(int id, Species species, string name) { 
            Id = id;
            Species = species;
            Name = name;
        }

    }
}
