using DataBindingProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingProject.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<User> Users { get; set; }

        private int _id;
        private string _name;
        private string _username;

        public int Id {
            get { return _id; }
            set { 
                if (value != _id)
                    _id = value;
                    OnPropertyChanged();
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                    _name = value;
                    OnPropertyChanged();
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                if (value != _username)
                    _username = value;
                    OnPropertyChanged();
            }
        }

        public UserViewModel()
        {
            Users = new BindingList<User>();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public void AddUser()
        {
            Users.Add(new User(Id, Name, Username));
            Id = 0;
            Name = Username = string.Empty;
        }
    }
}