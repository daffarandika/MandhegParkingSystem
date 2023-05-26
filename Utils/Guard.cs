using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandhegParkingSystem.Utils
{
    internal class Guard
    {
        public static bool FailsAgainstNull(Control[] controls)
        {
            bool fail = false;
            foreach (Control control in controls)
            {
                if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        fail = true;
                        break;
                    }
                }
                else
                {
                    if (control.Text == "")
                    {
                        fail = true;
                        break;
                    }
                }
            }
            return fail;
        }
    }
}
