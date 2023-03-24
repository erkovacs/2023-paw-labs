using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnLabWinFormsApp.Entities
{
    internal class RaceTrack
    {
        private List<Car> _cars;
        public string Name { get; set; }
        public List<Car> Cars { get { return _cars; } }
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
