using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VizeHavaDurumAKD
{
    public partial class Form1 : Form
    {
        string hava_durumu_link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml"
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(hava_durumu_link);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
