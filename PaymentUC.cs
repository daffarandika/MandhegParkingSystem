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
    public partial class PaymentUC : UserControl
    {
        public PaymentUC()
        {
            InitializeComponent();
            license_plateTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            license_plateTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            List<string> licensePlates = Vars.db.Vehicles.Select(v => v.license_plate).ToList();
            AutoCompleteStringCollection licenses = new AutoCompleteStringCollection();
            foreach (string item in licensePlates)
            {
                licenses.Add(item);
            }
            license_plateTextBox.AutoCompleteCustomSource= licenses;    
        }


        private void PaymentUC_Load(object sender, EventArgs e)
        {

        }
    }
}
