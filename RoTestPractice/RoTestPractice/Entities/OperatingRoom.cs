using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTestPractice.Entities
{
    [Serializable]
    public class OperatingRoom
    {
        public int Number { get; set; }
        public List<Doctor> Doctors { get; set; }

        public OperatingRoom() 
        {
            Doctors = new List<Doctor>();
        }
        public OperatingRoom(int number) : this()
        {
           Number = number;
        }
        public override string ToString()
        {
            return "Operating Room no. " + Number;
        }
    }
}
