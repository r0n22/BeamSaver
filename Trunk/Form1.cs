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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btt_startStop_Click(object sender, EventArgs e)
        {
    /*        XmlDocument Return = new XmlDocument();
            Return.Load("http://api.wunderground.com/weatherstation/WXCurrentObXML.asp?ID=" + txt_WUid.Text);
            int WindDirection = Convert.ToInt32(Return.GetElementsByTagName("wind_degrees")[0].InnerText);
            decimal WindSpeed = Convert.ToDecimal(Return.GetElementsByTagName("wind_mph")[0].InnerText);
            MessageBox.Show(string.Format("Wind Direction:{0} @ a speed of {1}", WindDirection.ToString(), WindSpeed.ToString()));
     */
        }

        private void btt_ComPortConfig_Click(object sender, EventArgs e)
        {
            new ComPortConfig().Show();
        }
    }
}
