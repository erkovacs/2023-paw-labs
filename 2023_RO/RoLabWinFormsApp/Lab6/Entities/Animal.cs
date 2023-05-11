using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoLabWinFormsApp.Entities
{
    public enum Species
    {
        None,
        Chimpanzee,
        Elephant,
        Lion,
        Tiger,
        Zebra
    }
    public class Animal
    {
        public int Id { get; set; }
        public Species Species { get; set; }
        public string Name { get; set; }

        public Animal() { }
        public Animal(int id, Species species, string name) { 
            Id = id;
            Species = species;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Species: {Species}, Name: {Name}";
        }
    }
}
