using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingProject.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public User() { }
        public User (int id, string name, string username)
        {
            Id = id;
            Name = name;
            Username = username;
        }
    }
}
