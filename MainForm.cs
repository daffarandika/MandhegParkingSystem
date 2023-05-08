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
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 100;
            timer.Tick += updateTime;
            timer.Start();
        }

        private void updateTime(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd, dd MM yyyy HH:mm:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = Vars.employee.name;
        }
    }
}
