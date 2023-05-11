using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnLabWinFormsApp.Entities
{
    public enum Manufacturer
    {
        None,
        BMW,
        Mercedes,
        Ferrari,
        Honda,
        Lamborghini
    }

    public class Car
    {
        static int NextId = 1;

        public int Id { get; set; }
        public float Displacement { get; set; }
        public int TopSpeed { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public Car()
        {
            Id = NextId;
            NextId++;
        }

        public Car(float displacement, int topSpeed, Manufacturer manufacturer)
        : this()
        {
            Displacement = displacement;
            TopSpeed = topSpeed;
            Manufacturer = manufacturer;
        }

    }
}
