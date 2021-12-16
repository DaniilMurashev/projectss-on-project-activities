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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = 0;

            if (comboBox1.SelectedIndex == 0)
            { s1 = 10; }
            if (comboBox1.SelectedIndex == 1)
            { s1 = 15; }
            if (comboBox1.SelectedIndex == 2)
            { s1 = 20; }

            string kol = textBox1.Text;

            int kol1 = Convert.ToInt32(kol);

            int itog = s1 * kol1;

            label4.Text = Convert.ToString(itog);
        }
    }
}
