using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace CanSatSerial
{
    public partial class MainForm : Form
    {
        public string serialdata;
        public string seriald;
        public string[] splitd;
        public bool second;
        public int number;
        //public float oldheight = 0, oldtime = 0, speed;
        public float[] t = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public float[] h = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public float[] speed = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public ChartForm chart = new ChartForm();
        public Monitor mon = new Monitor();
        public int i;
        public string[] data = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};

        public MainForm()
        {
            InitializeComponent();

            serialPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                serialPorts.Items.Add(ports[i]);
            }

            chart.Owner = this;
            chart.Show();
            chart.Visible = false;

            mon.Owner = this;
            mon.Show();
            mon.Visible = false;

        }

        private void serialRenew_Click(object sender, EventArgs e)
        {
            serialPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                serialPorts.Items.Add(ports[i]);
            }
        }

        private void serialStart_Click(object sender, EventArgs e)
        {
            try
            {
                serial.PortName = serialPorts.Text;
                serial.BaudRate = (int) serialBaud.Value;
                serial.DataBits = 8;
                serial.Parity = System.IO.Ports.Parity.None;
                serial.StopBits = System.IO.Ports.StopBits.One;
                serial.ReadTimeout = 1000;
                serial.WriteTimeout = 1000;
                serial.Open();

                serialLog.AppendText("Порт открыт" + "\n");
                serialLog.ScrollToCaret();
            }
            catch (Exception ex)
            {
                serialLog.AppendText("Невозможно открыть порт: " + ex.Message + "\n");
                serialLog.ScrollToCaret();
                return;
            }
        }

        private void serialStop_Click(object sender, EventArgs e)
        {
            try
            {
                serial.Close();
                serialLog.AppendText("Порт закрыт" + "\n");
                serialLog.ScrollToCaret();
            }
            catch (Exception ex)
            {
                serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                serialLog.ScrollToCaret();
                return;
            }
            second = false;
        }

        private void serialSend_Click(object sender, EventArgs e)
        {
            try
            {
                serial.Write(serialMessage.Text);
                serialLog.AppendText("Пользователь @ ПК: " + serialMessage.Text + "\n");
                serialLog.ScrollToCaret();
            }
            catch (Exception ex)
            {
                serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                serialLog.ScrollToCaret();
                return;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            /*second = false;
            table.Rows.Clear();
            chart.Hchart.Series[0].Points.Clear();
            number = 0;
            serialLog.AppendText("Сброс данных" + "\n");
            serialLog.ScrollToCaret();*/

            second = false;
            //table.Invoke((MethodInvoker)delegate
            //{
            //    table.Rows.Clear();
            //});
            chart.Hchart.Invoke((MethodInvoker)delegate
            {
                chart.Hchart.Series[0].Points.Clear();
            });
            chart.Hchart.Invoke((MethodInvoker)delegate
            {
                chart.Hchart.Series[1].Points.Clear();
            });

            for (i = 0; i <= 599; i++)
            {
                t[i] = 0;
                h[i] = 0;
                speed[i] = 0;
            }

            number = 0;
            serialLog.Invoke((MethodInvoker)delegate
            {
                serialLog.AppendText("Сброс данных" + "\n");
                serialLog.ScrollToCaret();
            });
        }
    
        private void heightbarLblLabel_Click(object sender, EventArgs e)
        {
            /*heightbarLblLabel.ForeColor = Color.FromName("ControlText");
            try
            {
                chart.Visible = true;
                chart.Show();
            }
            catch (ObjectDisposedException) {
            }*/
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            chart.clz = true;
            chart.Close();
            mon.clz = true;
            mon.Close();
            Application.Exit();
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*if (mon.rst)
            {
                second = false;
                seriald = "";
                chart.Hchart.Invoke((MethodInvoker)delegate
                {
                    chart.Hchart.Series[0].Points.Clear();
                });
                mon.reset.ForeColor = Color.FromName("Red");
                number = 0;
                mon.rst = false;
            }*/

            if (second)
            {
                seriald += serial.ReadExisting();

                number++;

                numberLabel.Invoke((MethodInvoker)delegate
                {
                    numberLabel.Text = number.ToString();
                });

                serialLog.Invoke((MethodInvoker)delegate
                {
                    serialLog.AppendText("Устройство: " + seriald + "\n");
                    serialLog.ScrollToCaret();
                });
                if (splitbysemicolonSw.Checked)
                {
                    try
                    {
                        splitd = seriald.Split(';');
                    }
                    catch (Exception ex)
                    {
                        serialLog.Invoke((MethodInvoker)delegate
                        {
                            serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                            serialLog.ScrollToCaret();
                        });
                        return;
                    }
                }
                else {
                    try
                    {
                        splitd[0] = seriald.Substring(0, 5);
                        splitd[1] = seriald.Substring(6, 6);
                        splitd[2] = seriald.Substring(13, 10);
                        splitd[3] = seriald.Substring(24, 11);
                        splitd[4] = seriald.Substring(36, 1);
                    }
                    catch (Exception ex)
                    {
                        serialLog.Invoke((MethodInvoker)delegate
                        {
                            serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                            serialLog.ScrollToCaret();
                        });
                        return;
                    }
                }

                try
                {
                    try
                    {
                        t[number - 1] = ((int) Convert.ToSingle(splitd[0]) / 10) / 10;
                        //if(t[number-1] <= t[number-2])
                        //{
                        //    t[number - 1] += t[number - 2];
                        //}
                        h[number - 1] = Convert.ToSingle(splitd[1]);
                        for (i = number; i <= 599; i++)
                        {
                            t[i] = t[number - 1];
                            h[i] = h[number - 1];
                        }
                    }
                    catch (Exception ex)
                    {
                        serialLog.Invoke((MethodInvoker)delegate
                        {
                            serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                            serialLog.ScrollToCaret();
                        });
                        return;
                    }

                    if (number >= 2)
                    {
                        speed[number - 2] = (h[number - 1] - h[number - 2]) / (t[number - 1] - t[number - 2]);
                        
                        //for (i = number - 1; i <= 598; i++)
                        //{
                        //    speed[i] = speed[number - 2];
                        //}
                    }

                    timeLabel.Invoke((MethodInvoker)delegate
                    {
                        if (0 < splitd.Length)
                        {
                            timeLabel.Text = splitd[0] + "0 мс";
                        }
                    });
                    heightbarLabel.Invoke((MethodInvoker)delegate
                    {
                        if (1 < splitd.Length)
                        {
                            heightbarLabel.Text = splitd[1] + " м";
                        }
                    });
                    if (number >= 2)
                    {
                        speedLabel.Invoke((MethodInvoker)delegate
                        {
                            speedLabel.Text = speed[number - 2] + " м/c";
                        });
                    }
                    gps1Label.Invoke((MethodInvoker)delegate
                    {
                        if (2 < splitd.Length)
                        {
                            gps1Label.Text = splitd[2];
                        }
                    });
                    gps2Label.Invoke((MethodInvoker)delegate
                    {
                        if (3 < splitd.Length)
                        {
                            gps2Label.Text = splitd[3];
                        }
                    });
                    
                    phaseLabel.Invoke((MethodInvoker)delegate
                    {
                        if (4 < splitd.Length)
                        {
                            phaseLabel.Text = splitd[4];
                        }
                    });

                    mon.timeLabel.Invoke((MethodInvoker)delegate
                    {
                        if (0 < splitd.Length)
                        {
                            mon.timeLabel.Text = splitd[0] + "0 мс";
                        }
                    });
                    mon.heightbarLabel.Invoke((MethodInvoker)delegate
                    {
                        if (1 < splitd.Length)
                        {
                            mon.heightbarLabel.Text = splitd[1] + " м";
                        }
                    });
                    if (number >= 2)
                    {
                        mon.speedLabel.Invoke((MethodInvoker)delegate
                        {
                            mon.speedLabel.Text = speed[number - 2] + " м/c";
                        });
                    }
                    mon.gps1Label.Invoke((MethodInvoker)delegate
                    {
                        if (2 < splitd.Length)
                        {
                            mon.gps1Label.Text = splitd[2];
                        }
                    });
                    mon.gps2Label.Invoke((MethodInvoker)delegate
                    {
                        if (3 < splitd.Length)
                        {
                            mon.gps2Label.Text = splitd[3];
                        }
                    });
                    mon.phaseLabel.Invoke((MethodInvoker)delegate
                    {
                        if (4 < splitd.Length)
                        {
                            mon.phaseLabel.Text = splitd[4];
                        }
                    });
                }
                catch (Exception ex)
                {
                    serialLog.Invoke((MethodInvoker)delegate
                    {
                        serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                        serialLog.ScrollToCaret();
                    });
                    return;
                }

                /*try
                {
                    chart.Hchart.Invoke((MethodInvoker)delegate
                    {
                        chart.Hchart.Series[1].Points.DataBindXY(t, speed);
                    });
                }
                catch (Exception ex)
                {
                    serialLog.Invoke((MethodInvoker)delegate
                    {
                        serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                        serialLog.ScrollToCaret();
                    });
                    return;
                }*/

                try
                {
                    chart.Hchart.Invoke((MethodInvoker)delegate
                    {
                        chart.Hchart.Series[0].Points.DataBindXY(t, h);
                    });
                }
                catch (Exception ex)
                {
                    serialLog.Invoke((MethodInvoker)delegate
                    {
                        serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                        serialLog.ScrollToCaret();
                    });
                    return;
                }


                if (number >= 2) {
                    table.Invoke((MethodInvoker)delegate
                    {
                        if (5 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], splitd[3], splitd[4]);
                        }
                        if (4 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], splitd[3], splitd[4]);
                        }
                        else if (3 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], splitd[3], "-");
                        }
                        else if (2 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], "-", "-");
                        }
                        else if (1 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), "-", "-", "-");
                        }
                        else if (0 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", "-", "-", "-", "-");
                        }
                    });
                }
                else {

                    table.Invoke((MethodInvoker)delegate
                    {
                        if (4 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", splitd[2], splitd[3], splitd[4]);
                        }
                        else if (3 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", splitd[2], splitd[3], "-");
                        }
                        else if (2 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", splitd[2], "-", "-");
                        }
                        else if (1 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", "-", "-", "-");
                        }
                        else if (0 < splitd.Length)
                        {
                            table.Rows.Add(splitd[0] + "0 мс", "-", "-", "-", "-");
                        }
                    });
                }

                seriald = "";


            }
           else {
                seriald = serial.ReadExisting();
            }

            second = !second;
        }

        private void OpenMonitor_Click(object sender, EventArgs e)
        {
            mon.Visible = !(mon.Visible);
        }

        private void OpenChart_Click(object sender, EventArgs e)
        {
            chart.Visible = !(chart.Visible);
        }

        private void splitbysemicolonSw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (serialMessage.Text != "")
            {
                try
                {
                    data = File.ReadAllLines(serialMessage.Text);
                }
                catch (Exception ex)
                {
                    serialLog.Invoke((MethodInvoker)delegate
                    {
                        serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                        serialLog.ScrollToCaret();
                    });
                    return;
                }
                for (number = 1; number <= data.Length; number++)
                {
                    numberLabel.Invoke((MethodInvoker)delegate
                    {
                        numberLabel.Text = number.ToString();
                    });

                    serialLog.Invoke((MethodInvoker)delegate
                    {
                        serialLog.AppendText("Устройство: " + data[number-1] + "\n");
                        serialLog.ScrollToCaret();
                    });
                    if (splitbysemicolonSw.Checked)
                    {
                        try
                        {
                            splitd = data[number-1].Split(';');
                        }
                        catch (Exception ex)
                        {
                            serialLog.Invoke((MethodInvoker)delegate
                            {
                                serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                                serialLog.ScrollToCaret();
                            });
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            splitd[0] = data[number-1].Substring(0, 5);
                            splitd[1] = data[number-1].Substring(6, 6);
                            splitd[2] = data[number-1].Substring(13, 10);
                            splitd[3] = data[number-1].Substring(24, 11);
                            splitd[4] = data[number-1].Substring(36, 1);
                        }
                        catch (Exception ex)
                        {
                            serialLog.Invoke((MethodInvoker)delegate
                            {
                                serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                                serialLog.ScrollToCaret();
                            });
                            return;
                        }
                    }

                    try
                    {
                        try
                        {
                            t[number - 1] = ((int)Convert.ToSingle(splitd[0]) / 10) / 10;
                            h[number - 1] = Convert.ToSingle(splitd[1]);                            
                        }
                        catch (Exception ex)
                        {
                            serialLog.Invoke((MethodInvoker)delegate
                            {
                                serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                                serialLog.ScrollToCaret();
                            });
                        }

                        if (number >= 2)
                        {
                            speed[number - 2] = (h[number - 1] - h[number - 2]) / (t[number - 1] - t[number - 2]);
                        }                        
                    }
                    catch (Exception ex)
                    {
                        serialLog.Invoke((MethodInvoker)delegate
                        {
                            serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                            serialLog.ScrollToCaret();
                        });
                    }

                    if (number >= 2)
                    {
                        table.Invoke((MethodInvoker)delegate
                        {
                            if (5 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], splitd[3], splitd[4]);
                            }
                            if (4 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], splitd[3], splitd[4]);
                            }
                            else if (3 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], splitd[3], "-");
                            }
                            else if (2 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), splitd[2], "-", "-");
                            }
                            else if (1 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", speed[number - 2].ToString(), "-", "-", "-");
                            }
                            else if (0 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", "-", "-", "-", "-");
                            }
                        });
                    }
                    else
                    {

                        table.Invoke((MethodInvoker)delegate
                        {
                            if (4 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", splitd[2], splitd[3], splitd[4]);
                            }
                            else if (3 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", splitd[2], splitd[3], "-");
                            }
                            else if (2 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", splitd[2], "-", "-");
                            }
                            else if (1 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", splitd[1] + " м", "-", "-", "-", "-");
                            }
                            else if (0 < splitd.Length)
                            {
                                table.Rows.Add(splitd[0] + "0 мс", "-", "-", "-", "-");
                            }
                        });
                    }
                }
                timeLabel.Invoke((MethodInvoker)delegate
                {
                    if (0 < splitd.Length)
                    {
                        timeLabel.Text = splitd[0] + "0 мс";
                    }
                });
                heightbarLabel.Invoke((MethodInvoker)delegate
                {
                    if (1 < splitd.Length)
                    {
                        heightbarLabel.Text = splitd[1] + " м";
                    }
                });
                if (number >= 2)
                {
                    speedLabel.Invoke((MethodInvoker)delegate
                    {
                        speedLabel.Text = speed[number - 2] + " м/c";
                    });
                }
                gps1Label.Invoke((MethodInvoker)delegate
                {
                    if (2 < splitd.Length)
                    {
                        gps1Label.Text = splitd[2];
                    }
                });
                gps2Label.Invoke((MethodInvoker)delegate
                {
                    if (3 < splitd.Length)
                    {
                        gps2Label.Text = splitd[3];
                    }
                });

                phaseLabel.Invoke((MethodInvoker)delegate
                {
                    if (4 < splitd.Length)
                    {
                        phaseLabel.Text = splitd[4];
                    }
                });

                mon.timeLabel.Invoke((MethodInvoker)delegate
                {
                    if (0 < splitd.Length)
                    {
                        mon.timeLabel.Text = splitd[0] + "0 мс";
                    }
                });
                mon.heightbarLabel.Invoke((MethodInvoker)delegate
                {
                    if (1 < splitd.Length)
                    {
                        mon.heightbarLabel.Text = splitd[1] + " м";
                    }
                });
                if (number >= 2)
                {
                    mon.speedLabel.Invoke((MethodInvoker)delegate
                    {
                        mon.speedLabel.Text = speed[number - 2] + " м/c";
                    });
                }
                mon.gps1Label.Invoke((MethodInvoker)delegate
                {
                    if (2 < splitd.Length)
                    {
                        mon.gps1Label.Text = splitd[2];
                    }
                });
                mon.gps2Label.Invoke((MethodInvoker)delegate
                {
                    if (3 < splitd.Length)
                    {
                        mon.gps2Label.Text = splitd[3];
                    }
                });
                mon.phaseLabel.Invoke((MethodInvoker)delegate
                {
                    if (4 < splitd.Length)
                    {
                        mon.phaseLabel.Text = splitd[4];
                    }
                });

                for (i = number; i <= 599; i++)
                {
                    t[i] = t[number - 1];
                    h[i] = h[number - 1];
                }
                try
                {
                    chart.Hchart.Invoke((MethodInvoker)delegate
                    {
                        chart.Hchart.Series[0].Points.DataBindXY(t, h);
                    });
                }
                catch (Exception ex)
                {
                    serialLog.Invoke((MethodInvoker)delegate
                    {
                        serialLog.AppendText("Ошибка: " + ex.Message + "\n");
                        serialLog.ScrollToCaret();
                    });
                }
            }
        }
    }
}
