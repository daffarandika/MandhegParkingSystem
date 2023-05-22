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
        public static void HideColumns(this DataGridView dgv, string[] columns)
        {
            foreach (string column in columns)
            {
                dgv.Columns[column].Visible = false;
            }
        }
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
        public static void Clear(this Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedIndex = -1;
                }
                if (control is RadioButton)
                {
                    (control as RadioButton).Checked = false;
                } else
                {
                    control.Text = "";
                }
            }
        }
        public static void Disable(this Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.Enabled = false;
            }
        }
        public static void Enable(this Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.Enabled = true;
            }
        }
    }
}
