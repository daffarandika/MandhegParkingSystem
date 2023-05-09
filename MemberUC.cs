using MandhegParkingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandhegParkingSystem
{
    public partial class MemberUC : UserControl
    {
        Control[] inputFields;
        Control[] crudButtons;
        public MemberUC()
        {
            InitializeComponent();
            inputFields = new Control[]
            {
                nameTextBox, emailTextBox, phone_numberTextBox, addressTextBox, rbMale, rbFemale
            };
            crudButtons = new Control[]
            {
                btnInsert, btnDelete, btnUpdate
            };
        }

        private void MemberUC_Load(object sender, EventArgs e)
        {
            memberDataGridView.DataSource = Vars.db.Members.Select(m => new
            {
                Name = m.name,
                Membership = m.Membership.name.ToString(),
                Email = m.email,
                Phone_Number = m.phone_number,
                Address = m.address,
                Date_of_Birth = m.date_of_birth,
                Gender = m.gender
            }).ToList();
            memberDataGridView.Setup();
            membership_typeComboBox.DataSource = Vars.db.Memberships.ToList();
            membership_typeComboBox.ValueMember = "id";
            membership_typeComboBox.DisplayMember = "name";
            membership_typeComboBox.Setup();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            foreach (Control c in crudButtons)
            {
                c.Enabled = false;
            }

            foreach (Control c in inputFields)
            {
                c.Text = "";
            }
        }

        private void memberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = memberDataGridView.CurrentRow;
            nameTextBox.Text = row.Cells["name"].Value.ToString();
            emailTextBox.Text = row.Cells["email"].Value.ToString();
            phone_numberTextBox.Text = row.Cells["phone_number"].Value.ToString();
            membership_typeComboBox.Text = row.Cells["membership"].Value.ToString();
            addressTextBox.Text = row.Cells["address"].Value.ToString();
            date_of_birthDateTimePicker.Text = row.Cells["date_of_birth"].Value.ToString();
            if (row.Cells["gender"].Value.ToString() == "Male")
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;
            } else
            {
                rbFemale.Checked = true;
                rbMale.Checked = false; 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (Control c in crudButtons)
            {
                c.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Control c in crudButtons)
            {
                c.Enabled = false;
            }
        }
    }
}
