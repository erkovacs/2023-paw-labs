using RoLabWinFormsApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem4WinForms
{
    public partial class EditForm : Form
    {
        Animal _animal;

        public EditForm()
        {
            InitializeComponent();
            species.Items.AddRange(Enum.GetNames(typeof(Species)));
        }

        public EditForm(Animal animal) : this() 
        { 
            _animal = animal;
            id.Text = animal.Id.ToString();
            species.Text = animal.Species.ToString();
            name.Text = animal.Name;
        }

        private Species FromString(string species)
        {
            var result = Species.None;
            Enum.TryParse<Species>(species, out result);
            return result;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _animal.Species = FromString(species.Text);
            _animal.Name = name.Text;
        }
    }
}
