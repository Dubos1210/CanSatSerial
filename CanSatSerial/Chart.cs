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
    public partial class ChartForm : Form
    {

        public bool clz = false;

        public ChartForm()
        {
            InitializeComponent();

            MainForm main = this.Owner as MainForm;
        }

        private void Chart_Resize(object sender, EventArgs e)
        {
            if (this.Height > 40 && this.Width > 16)
            {
                Hchart.Height = this.Height - 40;
                Hchart.Width = this.Width - 16;
            }
        }

        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clz)
            {
                e.Cancel = true;
                this.Visible = false;
                //this.WindowState = FormWindowState.Minimized;
            }
        }

    }
}
