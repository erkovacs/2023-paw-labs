using EnLabWinFormsApp.Entities;
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
    public partial class Form1 : Form
    {
        private RaceTrack _track;
        public Form1()
        {
            InitializeComponent();
            manufacturer.Items.AddRange(Enum.GetNames(typeof(Manufacturer)));
            _track = new RaceTrack("Nurburgring");
        }

        private void DisplayCars ()
        {
            carsLv.Items.Clear();

            foreach (var car in _track.Cars)
            {
                var listViewItem = new ListViewItem(car.Id.ToString());
                listViewItem.SubItems.Add(car.Displacement.ToString());
                listViewItem.SubItems.Add(car.TopSpeed.ToString());
                listViewItem.SubItems.Add(car.Manufacturer.ToString());

                carsLv.Items.Add(listViewItem);
            }
        }

        private bool IsDisplacementValid(decimal displacement)
        {
            return (displacement > 0 && displacement <= 10000);
        }

        private bool IsTopSpeedValid(decimal topSpeed)
        {
            return (topSpeed >= 0 && topSpeed <= 500);
        }

        private Manufacturer ParseManufacturer(string manufacturer)
        {
            Manufacturer result = Manufacturer.None;
            Enum.TryParse(manufacturer, out result);
            return result;
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            var car = new Car((float)displacement.Value, (int)topSpeed.Value, ParseManufacturer(manufacturer.Text));

            if (!ValidateChildren())
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _track.AddCar(car);

            DisplayCars();
        }

        private void displacement_Validating(object sender, CancelEventArgs e)
        {
            if (!IsDisplacementValid(displacement.Value))
            {
                errorProvider.SetError(displacement, "Error: invalid displacement.");
                e.Cancel = true;
            }
        }

        private void topSpeed_Validating(object sender, CancelEventArgs e)
        {
            if (!IsTopSpeedValid(topSpeed.Value))
            {
                errorProvider.SetError(topSpeed, "Error: invalid top speed.");
                e.Cancel = true;
            }
        }

        private void displacement_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(displacement, String.Empty);
        }

        private void topSpeed_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(topSpeed, String.Empty);
        }
    }
}
