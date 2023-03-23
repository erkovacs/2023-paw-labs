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
        private Zoo zoo;

        public Form1()
        {
            InitializeComponent();
            zoo = new Zoo("Bucharest");
        }

        private void addAnimalBtn_Click(object sender, EventArgs e)
        {

            var animal = new Animal((int)id.Value, /*species.Text*/ Species.Zebra, name.Text);
            zoo.AddAnimal(animal);
        }
    }
}
