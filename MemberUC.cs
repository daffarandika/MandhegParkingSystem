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
        public MemberUC()
        {
            InitializeComponent();
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

        }
    }
}
