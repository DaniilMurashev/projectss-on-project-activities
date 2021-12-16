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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = 0;

            if (radioButton1.Checked == true)
            { s1 = 5000; }
            if (radioButton2.Checked == true)
            { s1 = 3000; }
            if (radioButton3.Checked == true)
            { s1 = 1000; }

            string kol = textBox1.Text;

            int kol1 = Convert.ToInt32(kol);

            int itog = kol1 * 150 + s1;

            oplataLabel.Text = Convert.ToString(itog);
        }
    }
}
