using RoLabWinFormsApp.Entities;
using Sem4WinForms;
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

namespace RoLabWinFormsApp
{
    public partial class MainForm : Form
    {
        private Zoo zoo;

        public MainForm()
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
                listViewItem.Tag = animal;
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

        private void animalsLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (animalsLv.SelectedItems.Count > 0)
            {
                var animal = (Animal)animalsLv.SelectedItems[0].Tag;

                EditForm animalForm = new EditForm(animal);
                if (animalForm.ShowDialog() == DialogResult.OK)
                { 
                    DisplayAnimals();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML | *.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Zoo));
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                    serializer.Serialize(stream, zoo);
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                XmlSerializer serializer = new XmlSerializer(typeof(Zoo));

                using (FileStream stream = File.OpenRead(openFileDialog.FileName))
                {
                    zoo = (Zoo)serializer.Deserialize(stream);
                    DisplayAnimals();
                }
            }
        }
    }
}
