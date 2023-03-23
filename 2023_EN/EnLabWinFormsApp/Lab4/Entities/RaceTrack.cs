using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Entities
{
    internal class RaceTrack
    {
        private List<Car> _cars;
        public string Name { get; set; }

        public RaceTrack() { }

        public RaceTrack(string name) {
            Name = name;
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }
    }
}
