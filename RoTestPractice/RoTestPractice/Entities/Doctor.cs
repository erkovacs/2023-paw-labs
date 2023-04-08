using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTestPractice.Entities
{
    [Serializable]
    public class Doctor : IComparable<Doctor>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }

        public Doctor() { }
        public Doctor(int id, string name, bool isAvailable) 
        {
            Id = id;
            Name = name;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return "Dr. " + Name + ", available=" + IsAvailable;
        }

        public int CompareTo(Doctor other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
