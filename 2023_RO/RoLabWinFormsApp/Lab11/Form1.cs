using Lab11.Database;
using Lab11.Entities;

namespace Lab11
{
    public partial class Form1 : Form
    {
        private UserContext context;
        public Form1()
        {
            InitializeComponent();
            context = new UserContext();
            userBindingSource.DataSource = context.Users.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = nameTb.Text;
            user.Date = dateDtp.Value;

            context.Users.Add(user);
            context.SaveChanges();
            userBindingSource.DataSource = context.Users.ToList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (usersDgv.SelectedRows.Count > 0)
            {
                User user = userBindingSource.Current as User;
                context.Users.Remove(user);
                context.SaveChanges();
                userBindingSource.DataSource = context.Users.ToList();
            }
        }

        private void usersDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (userBindingSource.Current != null)
            {
                User user = userBindingSource.Current as User;
                context.Users.Update(user);
                context.SaveChanges();
                userBindingSource.DataSource = context.Users.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}