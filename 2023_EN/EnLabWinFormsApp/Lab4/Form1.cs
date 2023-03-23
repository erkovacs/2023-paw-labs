using Lab4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
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

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            var car = new Car((float)displacement.Value, (int)topSpeed.Value, Manufacturer.Honda);
            _track.AddCar(car);
        }
    }
}
