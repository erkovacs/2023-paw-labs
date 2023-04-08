using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnTestPractice.Entities
{
    [Serializable]
    public class Car : IComparable<Car>
    {
        public int CarId { get; set; }
        public bool HasValidParkingTicket { get; set; }
        public string LicencePlate { get; set; }
        
        public Car() { }
        public Car(int carId, bool hasValidParkingTicket, string licencePlate)
        {
            CarId = carId;
            HasValidParkingTicket = hasValidParkingTicket;
            LicencePlate = licencePlate;
        }

        public int CompareTo(Car other)
        {
            return LicencePlate.CompareTo(other.LicencePlate);
        }
    }
}
