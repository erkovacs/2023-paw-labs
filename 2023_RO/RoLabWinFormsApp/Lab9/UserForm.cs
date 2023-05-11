using DataBindingProject.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingProject
{
    public partial class UserForm : Form
    {

        public UserViewModel ViewModel { get; set; }

        public UserForm(UserViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ctrlId.DataBindings.Add("Value", ViewModel, "Id");
            ctrlName.DataBindings.Add("Text", ViewModel, "Name");
            ctrlUsername.DataBindings.Add("Text", ViewModel, "Username");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ViewModel.AddUser();
        }
    }
}
