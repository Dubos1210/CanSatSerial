using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanSatSerial
{
    public partial class Monitor : Form
    {
        public MainForm main;
        public bool clz = false;
        public bool rst = false;

        public Monitor()
        {
            InitializeComponent();

            main = this.Owner as MainForm;
        }

        private void Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clz)
            {
                e.Cancel = true;
                this.Visible = false;
                //this.WindowState = FormWindowState.Minimized;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //rst = true;
            //reset.ForeColor = Color.FromName("Black");
            main.chart.Hchart.Series[0].Points.Clear();
            main.chart.Hchart.Series[1].Points.Clear();
            main.number = 0;
            main.seriald = "";
            main.second = false;
        }
    }
}
