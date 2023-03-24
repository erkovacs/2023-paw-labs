using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnLabWinFormsApp.Entities
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
        static int NextId = 1;

        public int Id { get; private set; }
        public float Displacement { get; private set; }
        public int TopSpeed { get; private set; }
        public Manufacturer Manufacturer { get; private set; }

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
