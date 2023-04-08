using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnTestPractice.Entities
{
    [Serializable]
    public class ParkingLot
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
        public ParkingLot() 
        {
            Cars = new List<Car>();
        }

        public ParkingLot(string name) : this()
        {
            Name = name;
        }

        public ParkingLot(string name, List<Car> cars) : this(name)
        {
            Cars = cars;
        }
    }
}
