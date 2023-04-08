using RoTestPractice.Entities;
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
using System.Xml.Serialization;

namespace RoTestPractice
{
    public partial class MainForm : Form
    {
        private OperatingRoom _operatingRoom;
        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayDoctors()
        {
            doctorsTv.Nodes[0].Nodes.Clear();
            _operatingRoom.Doctors.Sort();
            foreach (var doctor in _operatingRoom.Doctors)
            {
                TreeNode node = new TreeNode(doctor.ToString());
                node.Tag = doctor;
                doctorsTv.Nodes[0].Nodes.Add(node);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _operatingRoom = new OperatingRoom(1);
            TreeNode treeNode = new TreeNode(_operatingRoom.ToString());
            doctorsTv.Nodes.Add(treeNode);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var doctor = new Doctor();
            var form = new AddEditForm(doctor);
            if (DialogResult.OK == form.ShowDialog())
            {
                _operatingRoom.Doctors.Add(doctor);
                DisplayDoctors();
            }
        }

        private void doctorsTv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // var doctor = doctorsTv.SelectedNode.Tag as Doctor;
            var doctor = (Doctor)doctorsTv.SelectedNode.Tag;

            var form = new AddEditForm(doctor);
            if (DialogResult.OK == form.ShowDialog())
            {
                DisplayDoctors();
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.OpenWrite("export.bin"))
            {
                bf.Serialize(fs, _operatingRoom);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("export.bin"))
            {
                _operatingRoom = (OperatingRoom)bf.Deserialize(fs);
                DisplayDoctors();
            }
        }

        private void serializeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OperatingRoom));
            using (FileStream fs = File.OpenWrite("export.xml"))
            {
                xmlSerializer.Serialize(fs, _operatingRoom);
            }
        }

        private void deserializeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OperatingRoom));
            using (FileStream fs = File.OpenRead("export.xml"))
            {
                _operatingRoom = (OperatingRoom)xmlSerializer.Deserialize(fs);
                DisplayDoctors();
            }
        }

        private void serializeCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Id,Name,IsAvailable");
            sb.Append(Environment.NewLine);
            foreach (var doctor in _operatingRoom.Doctors)
            {
                sb.Append(doctor.Id);
                sb.Append(",");
                sb.Append(doctor.Name);
                sb.Append(",");
                sb.Append(doctor.IsAvailable);
                sb.Append(Environment.NewLine);
            }
            string csv = sb.ToString();
            using (StreamWriter sw = new StreamWriter("serialized.csv"))
            {
                sw.Write(csv);
            }
        }
    }
}
