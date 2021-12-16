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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string km = textBox1.Text;
            string l = textBox2.Text;

            int km1 = Convert.ToInt32(km);
            int l1 = Convert.ToInt32(l);

            int itog = Convert.ToDouble(km1);
            rashod.Text = Convert.ToString(l1); 
        }
    }
}
