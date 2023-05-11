using DataBindingProject.Entities;
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
    public partial class MainForm : Form
    {
        private UserViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new UserViewModel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _viewModel.Users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm(_viewModel);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var user = dgvUsers.SelectedRows[0];
                dgvUsers.Rows.Remove(user);
            }
        }
    }
}
