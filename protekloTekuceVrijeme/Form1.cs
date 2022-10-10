using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace statusSkript_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }

        DateTime pocetno = DateTime.Now;
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            tssTrenutno.Text = pocetno.ToString("HH:mm:ss tt");

            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            tssProteklo.Text = proteklo.Hours.ToString() + ":" +
                proteklo.Minutes.ToString() + ":"
                + proteklo.Seconds.ToString();
        }
    }
}
