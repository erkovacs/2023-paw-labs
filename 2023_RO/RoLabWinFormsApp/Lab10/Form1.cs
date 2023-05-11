using Lab10.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class DatabaseApp : Form
    {
        private string ConnectionString = "Data Source=database.db";
        private List<Invoice> Invoices;

        public DatabaseApp()
        {
            InitializeComponent();
            Invoices = new List<Invoice>();
        }

        private void DisplayInvoices()
        {
            invoicesLv.Items.Clear();
            foreach (var invoice in Invoices)
            {
                ListViewItem item = new ListViewItem(invoice.Id.ToString());
                item.SubItems.Add(invoice.Series.ToString());
                item.SubItems.Add(invoice.Amount.ToString("c"));
                item.Tag = invoice;
                invoicesLv.Items.Add(item);
            }
        }

        private void CreateInvoice(Invoice invoice)
        {
            var query = "insert into invoice(series, amount)" +
                        " values(@series, @amount); " +
                        "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@series", invoice.Series);
                command.Parameters.AddWithValue("@amount", invoice.Amount);
                long id = (long)command.ExecuteScalar();
                invoice.Id = (int)id;
                Invoices.Add(invoice);
            }
            DisplayInvoices();
        }

        private void ReadInvoice()
        {
            var query = "SELECT * FROM invoice";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        var invoice = new Invoice();
                        invoice.Id = (int)(long)reader["id"];
                        invoice.Series = (string)reader["series"];
                        invoice.Amount = (decimal)(double)reader["amount"];
                        Invoices.Add(invoice);
                    }
                }
            }
            DisplayInvoices();
        }

        private void addInvoiceBtn_Click(object sender, EventArgs e)
        {
            var invoice = new Invoice();
            invoice.Series = seriesTb.Text;
            invoice.Amount = decimal.Parse(amountTb.Text);
            CreateInvoice(invoice);
            seriesTb.Text = amountTb.Text = string.Empty;
        }

        private void DatabaseApp_Load(object sender, EventArgs e)
        {
            ReadInvoice();
        }
    }
}
