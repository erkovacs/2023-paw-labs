using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnLabWinFormsApp.Entities
{
    public class RaceTrack
    {
        private List<Car> _cars;
        public string Name { get; set; }
        public List<Car> Cars { get { return _cars; } }
        public RaceTrack() {
            _cars = new List<Car>();
        }

        public RaceTrack(string name) : this() {
            Name = name;
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

       
    }
}
