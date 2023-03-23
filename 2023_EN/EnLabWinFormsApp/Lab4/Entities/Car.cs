using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Entities
{
    internal enum Manufacturer
    {
        None,
        BMW,
        Mercedes,
        Ferrari,
        Honda,
        Lamborghini
    }

    internal class Car
    {
        public float Displacement { get; private set; }
        public int TopSpeed { get; private set; }
        public Manufacturer Manufacturer { get; private set; }

        public Car() { }

        public Car(float displacement, int topSpeed, Manufacturer manufacturer)
        {
            Displacement = displacement;
            TopSpeed = topSpeed;
            Manufacturer = manufacturer;
        }

    }
}
