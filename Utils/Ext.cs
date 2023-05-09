using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandhegParkingSystem.Utils
{
    public static class Ext
    {
        public static void Setup(this DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows= false;
            dgv.RowHeadersVisible=false;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderText = col.HeaderText.Replace('_', ' ');
                if (col.HeaderText.ToLower().Contains("date"))
                {
                    col.DefaultCellStyle.Format = "dd MMM yyyy";
                }
            }
        }
        public static void Setup(this ComboBox cmb)
        {
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.SelectedIndex = -1;
        }
    }
}
