using EnTestPractice.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnTestPractice
{
    public partial class MainForm : Form
    {
        private ParkingLot _parkingLot;
        public MainForm()
        {
            InitializeComponent();
            InitParkingLot();
        }

        public void InitParkingLot()
        {
            _parkingLot = new ParkingLot("My Parking Lot");
            var node = new TreeNode(_parkingLot.Name);
            node.Tag = _parkingLot;
            parkingLotTv.Nodes.Add(node);
        }

        private void DisplayCars ()
        {
            parkingLotTv.Nodes[0].Nodes.Clear();
            _parkingLot.Cars.Sort();
            foreach (var car in _parkingLot.Cars)
            {
                var node = new TreeNode(car.LicencePlate);
                node.Tag = car;
                parkingLotTv.Nodes[0].Nodes.Add(node);
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var car = new Car();
            AddEditForm form = new AddEditForm(car);
            if (DialogResult.OK == form.ShowDialog())
            {
                _parkingLot.Cars.Add(car);
                DisplayCars();
            }
        }

        private void parkingLotTv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var node = parkingLotTv.SelectedNode;
            if (node != null)
            {
                var car = node.Tag as Car;

                AddEditForm form = new AddEditForm(car);
                if (DialogResult.OK == form.ShowDialog())
                {
                    DisplayCars();
                }
            }
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = File.OpenWrite("serialized.bin"))
            {
                formatter.Serialize(f, _parkingLot);
            }
        }

        private void binaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream f = null;
            try
            {
                f = File.OpenRead("serialized.bin");
                _parkingLot = (ParkingLot)formatter.Deserialize(f);
                DisplayCars();
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally 
            {
                if (f != null)
                    f.Close();
            }
        }
    }
}
