using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoLabWinFormsApp.Entities
{
    public class Zoo
    {
        public string Location { get; set; }

        private List<Animal> _animals;

        public List<Animal> Animals {
            get { return _animals; }
        }

        public Zoo() { }

        public Zoo (string location)
        {
            Location = location;
            _animals = new List<Animal>();
        }

        public void AddAnimal (Animal animal)
        {
            _animals.Add(animal);
        }
    }
}
