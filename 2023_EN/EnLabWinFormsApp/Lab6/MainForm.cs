using EnLabWinFormsApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EnLabWinFormsApp
{
    public partial class MainForm : Form
    {
        private RaceTrack _track;
        public MainForm()
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
                listViewItem.Tag = car;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files | *.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(saveFileDialog.FileName);
                XmlSerializer serializer = new XmlSerializer(typeof(RaceTrack));
                using (FileStream stream = File.OpenWrite(saveFileDialog.FileName))
                    serializer.Serialize(stream, _track);
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RaceTrack));
                using (FileStream stream = File.OpenRead(openFileDialog.FileName))
                    _track = (RaceTrack)serializer.Deserialize(stream);
            }
            DisplayCars();
        }

        private void carsLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (carsLv.SelectedItems.Count > 0)
            {
                var car = carsLv.SelectedItems[0].Tag as Car;
                // var car = (Car)carsLv.SelectedItems[0].Tag;

                EditForm editForm = new EditForm(car);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayCars();
                }
            }
        }

        private void addCarDialogBtn_Click(object sender, EventArgs e)
        {
            var car = new Car();
            EditForm editForm = new EditForm(car);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                _track.AddCar(car);
                DisplayCars();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (carsLv.SelectedItems.Count > 0)
            {
                var car = carsLv.SelectedItems[0].Tag as Car;
                _track.Cars.Remove(car);
                DisplayCars();
            }
        }
    }
}
