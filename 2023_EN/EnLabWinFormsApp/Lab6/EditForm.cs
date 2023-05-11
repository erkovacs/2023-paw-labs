using EnLabWinFormsApp.Entities;
using EnLabWinFormsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnLabWinFormsApp
{
    public partial class EditForm : Form
    {
        private Car _car;
        public CarViewModel CarViewModel { get; set; }
        public EditForm()
        {
            InitializeComponent();
            manufacturer.Items.AddRange(Enum.GetNames(typeof(Manufacturer)));
        }

        public EditForm(Car car) : this()
        {
            _car = car;
            displacement.Value = (decimal)car.Displacement;
            topSpeed.Value = (decimal)car.TopSpeed;
            manufacturer.Text = car.Manufacturer.ToString();


        }

        private Manufacturer ParseManufacturer(string manufacturer)
        {
            Manufacturer result = Manufacturer.None;
            Enum.TryParse(manufacturer, out result);
            return result;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _car.Displacement = (float)displacement.Value;
            _car.TopSpeed = (int)topSpeed.Value;
            _car.Manufacturer = ParseManufacturer(manufacturer.Text);
        }
    }
}
