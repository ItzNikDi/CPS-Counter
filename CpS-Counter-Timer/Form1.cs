using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpS_Counter_Timer
{
    public partial class Form1 : Form
    {
        int _clicks = 0;
        double _time = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_time > 0)
            {
                _clicks++;
                label5.Text = _clicks.ToString();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_time > 0)
            {
                _time -= 0.1;
                label4.Text = _time.ToString();
            }
            else
            {
                timer1.Stop();
                label6.Text = ((double)_clicks/10).ToString();
            }
            if (_time <= 7.0)
            {
                label4.Location = new Point(150, 30);
            }
            if (label4.Text.Contains("-0"))
            {
                label4.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _time = 10;
            _clicks = 0;
            label5.Text = "0";
            label6.Text = "0";
            timer1.Stop();
            label4.Text = _time.ToString();
            label4.Location = new Point(150, 29);
        }
    }
}