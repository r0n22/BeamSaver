using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO.Ports;

namespace BeamSaver
{
    class BeamSaverWork
    {
        private SerialCom sp = new SerialCom();
        private int MaxDiectionChange = 20;
        public int WindDirection { get; set; }
        private int WindDirection_Previous;
        public decimal WindSpeed { get; set; }
        public decimal MaxWindSpeed { get; set; }
        public string WeatherID { get; set; }
        public string ComPort { get; set; }


        public int Delay { get; set; }
        

        /// <summary>
        /// Gets Weather From Weather Underground with Data from this class
        /// </summary>
        private void GetWeather()
        {
            XmlDocument Return = new XmlDocument();
            //Grab XML File
            Return.Load("http://api.wunderground.com/weatherstation/WXCurrentObXML.asp?ID=" + WeatherID);
            //Move WindDiection
            WindDirection_Previous = WindDirection;
            //Get new values
            WindDirection = Convert.ToInt32(Return.GetElementsByTagName("wind_degrees")[0].InnerText);
            WindSpeed = Convert.ToDecimal(Return.GetElementsByTagName("wind_mph")[0].InnerText);
        }

        /// <summary>
        /// Does Check to see should do the direction Change
        /// </summary>
        /// <returns>True to Change Direction</returns>
        private Boolean ChangeDirection()
        { return (Math.Abs(WindDirection - WindDirection_Previous) >= MaxDiectionChange && WindSpeed > MaxWindSpeed); }
        /// <summary>
        /// Checks Weather Data and sends apprioate commands
        /// </summary>
        public void checkAndSend(){
            sp.SetName(ComPort);
            GetWeather();
            string Command = "AP1"+WindDirection.ToString()+"\r";
            if (ChangeDirection())
            {
                sp.Open();
                //Send Commands
                sp.Send(Command);
                sp.Send("AM!\r");
                sp.Close();
               
            }
        }

    }
    /// <summary>
    /// Comm Port Class
    /// </summary>
    public class SerialCom
    {
        SerialPort sp;

        public SerialCom()
        {
            //sp = new SerialPort(s, 4800, Parity.None, 8, StopBits.One);
            sp = new SerialPort();
            sp.BaudRate = 4800;
            sp.Parity = Parity.None;
            sp.DataBits = 8;
            sp.StopBits = StopBits.One;
            sp.ReadTimeout = 1000;


        }
        public void SetName(string s){
            sp.PortName = s;
        }
        private byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);
        }

        public void Send(string s)
        {
            byte[] input = StrToByteArray(s);
            sp.Write(input, 0, input.Count());

        }
        public void Open()
        {
            sp.Open();
        }
        public void Close()
        {
            sp.Close();
        }
    }
}
