using MandhegParkingSystem.Models;
using MandhegParkingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace MandhegParkingSystem
{
    public partial class MemberUC : UserControl
    {
        Control[] inputFields;
        Control[] crudButtons;
        Control[] nonCrudButtons;
        CrudStateManager stateManager = new CrudStateManager();
        int selectedMemberId;
        public MemberUC()
        {
            InitializeComponent();
            inputFields = new Control[]
            {
                nameTextBox, emailTextBox, phone_numberTextBox, addressTextBox, rbMale, rbFemale, membership_typeComboBox, date_of_birthDateTimePicker
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
            FillDGV();
            membership_typeComboBox.DataSource = Vars.db.Memberships.ToList();
            membership_typeComboBox.ValueMember = "id";
            membership_typeComboBox.DisplayMember = "name";
            membership_typeComboBox.Setup();
            updateUI();
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
                    inputFields.Enable();
                    FillDGV();
                    break;
                case (CrudState.Update):
                    crudButtons.Disable();
                    nonCrudButtons.Enable();
                    inputFields.Enable();
                    FillDGV();
                    break;
                case (CrudState.Delete):
                    selectedMemberId = Convert.ToInt32(memberDataGridView.CurrentRow.Cells["id"].Value.ToString());
                    inputFields.Clear();
                    crudButtons.Disable();
                    nonCrudButtons.Enable();
                    inputFields.Enable();
                    break;
                case (CrudState.Idle):
                    inputFields.Disable();
                    inputFields.Clear();
                    crudButtons.Enable();
                    nonCrudButtons.Disable();
                    FillDGV();
                    break;
            }
        }

        private void FillDGV()
        {
            memberDataGridView.DataSource = Vars.db.Members.Where(m => m.deleted_at == null).Select(m => new
            {
                Id = m.id,
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
                "ua", "da", "ca", "id"
            });
            memberDataGridView.Setup();
        }

        private void memberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = memberDataGridView.CurrentRow;
            selectedMemberId = Convert.ToInt32(row.Cells["id"].Value);
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
            switch(stateManager.instance) {
                case CrudState.Insert:
                    if (Guard.FailsAgainstNull(inputFields))
                    {
                        MessageBox.Show("Input field cannot be empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Member newMember = new Member
                    {
                        name = nameTextBox.Text,
                        membership_id = Convert.ToInt32(membership_typeComboBox.SelectedValue.ToString()),
                        email = emailTextBox.Text,
                        phone_number = phone_numberTextBox.Text,
                        address = addressTextBox.Text,
                        date_of_birth = date_of_birthDateTimePicker.Value,
                        gender = (rbMale.Checked) ? "Male" : "Female",
                        created_at = DateTime.Now,
                        last_updated_at = null,
                        deleted_at = null
                    };
                    Vars.db.Members.Add(newMember);
                    Vars.db.SaveChanges();
                    break;
               case CrudState.Update:
                    if (Guard.FailsAgainstNull(inputFields))
                    {
                        MessageBox.Show("Input field cannot be empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var member = Vars.db.Members.Find(selectedMemberId);
                    member.name = nameTextBox.Text;
                    member.membership_id = Convert.ToInt32(membership_typeComboBox.SelectedValue);
                    member.email = emailTextBox.Text;
                    member.phone_number = phone_numberTextBox.Text;
                    member.address = addressTextBox.Text;
                    member.date_of_birth = date_of_birthDateTimePicker.Value.Date;
                    member.gender = (rbMale.Checked) ? "Male" : "Female";
                    member.last_updated_at = DateTime.Now;
                    Vars.db.SaveChanges();
                    label_time.Text = $"This record was last updated at {DateTime.Now.ToString(): ddd, yyyy MM dd, HH:mm:ss}";
                    break;
                case CrudState.Delete:
                    var memberToDelete = Vars.db.Members.Find(selectedMemberId);
                    memberToDelete.deleted_at = DateTime.Now;
                    Vars.db.SaveChanges();
                    break;
            }
            stateManager.ToIdle();
            updateUI();
        }

        private void date_of_birthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void membership_typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
