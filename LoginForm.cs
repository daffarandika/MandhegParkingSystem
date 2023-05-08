using MandhegParkingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandhegParkingSystem
{
    public partial class LoginForm : Form
    {
        bool hidePassword = true;
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = hidePassword;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            hidePassword = !hidePassword;
            passwordTextBox.UseSystemPasswordChar = hidePassword;
            passwordTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string password = Helper.Hash(passwordTextBox.Text);
            var employee = Vars.db.Employees.Where(emp => emp.id == id && emp.password == password);
            var empCount = employee.Count();
            if (empCount == 0)
            {
                MessageBox.Show("Employee not found");
            } else
            {
                Vars.employee = employee.First();
                Hide();
                new MainForm().ShowDialog();
                Close();
            }
        }
    }
}
