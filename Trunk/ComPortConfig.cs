using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace BeamSaver
{
    public partial class ComPortConfig : Form
    {
        public ComPortConfig()
        {
            InitializeComponent();
               foreach (string ports in System.IO.Ports.SerialPort.GetPortNames()) 
                { 
                    MessageBox.Show("Serial port avialible" + " " + ports); 
                } 
            //CB_ComPort.Items.AddRange(My.Computer.Ports.SerialPortNames.ToArray)
        }

        private void btt_save_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
