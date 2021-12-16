using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha16
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vis = visota.Text;
            string shir = shirina.Text;

            int S = Convert.ToInt32(vis) * Convert.ToInt32(shir);
            int tip = 0;
            if (comboBox1.SelectedIndex == 0) 
            { tip = 3000; }
            if (comboBox1.SelectedIndex == 1) 
            { tip = 5000; }
            if (checkBox1.Checked == true) 
            { tip = tip + 1000; }
            if (checkBox2.Checked == true) 
            { tip = tip + 500; }
            if (checkBox3.Checked == true)
            { tip = tip + 2500; }

            int itog = S * 1 + tip;
            oplataLabel.Text = Convert.ToString(itog);
        }
    }
}
