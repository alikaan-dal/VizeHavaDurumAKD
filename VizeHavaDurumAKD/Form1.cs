using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VizeHavaDurumAKD
{
    public partial class Form1 : Form
    {
        string hava_durumu_link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
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

            foreach (XmlNode node in nodes)
            {
                string Bogle = node["Bolge"].InnerText;
                string ili = node["ili"].InnerText;
                string Durum = node["Durum"].InnerText;
                string mak_sicaklik = node["Mak"].InnerText;
                string min_sicaklik = node["Min"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = Bogle;
                row.Cells[1].Value = ili;
                row.Cells[2].Value = Durum;
                row.Cells[3].Value = mak_sicaklik;
                row.Cells[4].Value = min_sicaklik;
                dataGridView1.Rows.Add(row);
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(hava_durumu_link);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");

            foreach (XmlNode node in nodes)
            {
                string Bogle = node["Bolge"].InnerText;
                string ili = node["ili"].InnerText;
                string Durum = node["Durum"].InnerText;
                string mak_sicaklik = node["Mak"].InnerText;
                string min_sicaklik = node["Min"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = Bogle;
                row.Cells[1].Value = ili;
                row.Cells[2].Value = Durum;
                row.Cells[3].Value = mak_sicaklik;
                row.Cells[4].Value = min_sicaklik;
                dataGridView1.Rows.Add(row);

            }
        }
    }
}
