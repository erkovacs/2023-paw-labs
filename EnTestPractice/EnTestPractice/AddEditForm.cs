using EnTestPractice.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnTestPractice
{
    public partial class AddEditForm : Form
    {
        private Car _car;
        public AddEditForm()
        {
            InitializeComponent();
        }

        public AddEditForm(Car car) : this() 
        { 
            _car = car;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (_car == null)
                _car = new Car();

            carId.Value = _car.CarId;
            hasValidParkingTicket.Checked = _car.HasValidParkingTicket;
            licencePlate.Text = _car.LicencePlate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _car.CarId = (int)carId.Value;
            _car.HasValidParkingTicket = hasValidParkingTicket.Checked;
            _car.LicencePlate = licencePlate.Text;
        }
    }
}
