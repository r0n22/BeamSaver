using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace BeamSaver
{
    
    public partial class Form1 : Form
    {
        BeamSaverWork BS;
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string ports in System.IO.Ports.SerialPort.GetPortNames())
            {
                CB_ComPort.Items.Add(ports);
            } 
        }

        private void btt_startStop_Click(object sender, EventArgs e)
        {
            if (btt_startStop.Text == "Start")
            {
                BS = new BeamSaverWork();
                BS.ComPort = Convert.ToString(CB_ComPort.SelectedItem);
                BS.WeatherID = txt_WUid.Text;
                BS.WindSpeed = Convert.ToDecimal(txt_MaxWind.Text);
                BS.Delay = Convert.ToInt32(txt_Interval.Text);
                tmrInterval.Interval = BS.Delay * 60000;
                btt_startStop.Text = "Stop";
                tmrInterval.Start();
            }
            else
            {
                tmrInterval.Stop();
                btt_startStop.Text = "Start";
                BS = null;
            }
        }

        private void btt_ComPortConfig_Click(object sender, EventArgs e)
        {
            new ComPortConfig().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BS.checkAndSend();
        }

    }
}
