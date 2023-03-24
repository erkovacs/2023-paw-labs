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

namespace RoLabWinFormsApp
{
    public partial class Form1 : Form
    {
        private Zoo zoo;

        public Form1()
        {
            InitializeComponent();
            species.Items.AddRange(Enum.GetNames(typeof(Species)));
            zoo = new Zoo("Bucharest");
        }

        private void DisplayAnimals()
        {
            animalsLv.Items.Clear();

            foreach (var animal in zoo.Animals)
            {
                var listViewItem = new ListViewItem(animal.Id.ToString());
                listViewItem.SubItems.Add(animal.Species.ToString());
                listViewItem.SubItems.Add(animal.Name);

                animalsLv.Items.Add(listViewItem);
            }
        }

        private bool IsIdValid(decimal id)
        {
            return (id > 0 && id <= 500);
        }

        private bool IsNameValid(string name)
        {
            return (name.Length > 4 && name.Length <= 25);
        }

        private Species FromString(string species)
        {
            var result = Species.None;
            Enum.TryParse<Species>(species, out result);
            return result;
        }

        private void addAnimalBtn_Click(object sender, EventArgs e)
        {
            var animal = new Animal((int)id.Value, FromString(species.Text), name.Text);

            if (!ValidateChildren())
            {
                MessageBox.Show("Error: Invalid values in form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsIdUnique(animal.Id))
            {
                MessageBox.Show("Error: Duplicate Id detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            zoo.AddAnimal(animal);
            DisplayAnimals();
        }

        private bool IsIdUnique(int id)
        {
            var animal = zoo.Animals.Find(a => a.Id == id);
            return animal == null;
        }

        private void id_Validating(object sender, CancelEventArgs e)
        {
            if (!IsIdValid(id.Value))
            {
                errorProvider.SetError(id, "Id is invalid!");
                e.Cancel = true;
            }
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNameValid(name.Text))
            {
                errorProvider.SetError(name, "Name is invalid!");
                e.Cancel = true;
            }
        }

        private void name_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(name, String.Empty);
        }

        private void id_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(id, String.Empty);
        }
    }
}
