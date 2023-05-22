using MandhegParkingSystem.Models;
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
        Control[] nonCrudButtons;
        CrudStateManager stateManager = new CrudStateManager();
        public MemberUC()
        {
            InitializeComponent();
            inputFields = new Control[]
            {
                nameTextBox, emailTextBox, phone_numberTextBox, addressTextBox, rbMale, rbFemale, membership_typeComboBox
            };
            crudButtons = new Control[]
            {
                btnInsert, btnDelete, btnUpdate
            };
            nonCrudButtons = new Control[]
            {
                btnSubmit, btnCancel
            };
        }

        private void MemberUC_Load(object sender, EventArgs e)
        {
            nonCrudButtons.Disable();
            memberDataGridView.DataSource = Vars.db.Members.Select(m => new
            {
                Name = m.name,
                Membership = m.Membership.name.ToString(),
                Email = m.email,
                Phone_Number = m.phone_number,
                Address = m.address,
                Date_of_Birth = m.date_of_birth,
                Gender = m.gender,
                ua = m.last_updated_at,
                ca = m.created_at,
                da = m.deleted_at,
            }).ToList();
            memberDataGridView.HideColumns(new string[]
            {
                "ua", "da", "ca"
            });
            memberDataGridView.Setup();
            membership_typeComboBox.DataSource = Vars.db.Memberships.ToList();
            membership_typeComboBox.ValueMember = "id";
            membership_typeComboBox.DisplayMember = "name";
            membership_typeComboBox.Setup();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            stateManager.ToInsert();
            updateUI();
        }

        private void updateUI()
        {
            switch (stateManager.instance)
            {
                case (CrudState.Insert):
                    inputFields.Clear();
                    crudButtons.Disable();
                    nonCrudButtons.Enable();
                    break;
                case (CrudState.Update):
                    crudButtons.Disable();
                    nonCrudButtons.Enable();
                    break;
                case (CrudState.Delete):
                    if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("yes");
                    }
                    break;
                case (CrudState.Idle):
                    inputFields.Clear();
                    crudButtons.Enable();
                    nonCrudButtons.Enable();
                    break;
            }
            crudButtons.Disable();
        }

        private void memberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stateManager.ToIdle();
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
            if (row.Cells["ua"].Value == null)
            {
                label_time.Text = $"This record was inserted at {DateTime.Parse(row.Cells["ca"].Value.ToString()):ddd, dd MM yyyy HH:mm:ss}";
            } else
            {
                label_time.Text = $"This record was last updated at {DateTime.Parse(row.Cells["ua"].Value.ToString()):dd, dd MM yyyy HH:mm:ss}";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            stateManager.ToUpdate();
            updateUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stateManager.ToDelete();
            updateUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            stateManager.ToIdle();
            updateUI();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            stateManager.ToIdle();
            updateUI();

        }
    }
}
