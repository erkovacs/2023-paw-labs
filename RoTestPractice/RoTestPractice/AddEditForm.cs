using RoTestPractice.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoTestPractice
{
    public partial class AddEditForm : Form
    {
        private Doctor _doctor;
        public AddEditForm()
        {
            InitializeComponent();
        }

        public AddEditForm(Doctor doctor) : this()
        {
            _doctor = doctor;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            doctorId.Value = _doctor.Id;
            doctorName.Text = _doctor.Name;
            doctorIsAvailble.Checked = _doctor.IsAvailable;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            _doctor.Id = (int)doctorId.Value;
            _doctor.Name = doctorName.Text;
            _doctor.IsAvailable = doctorIsAvailble.Checked;
        }
    }
}
