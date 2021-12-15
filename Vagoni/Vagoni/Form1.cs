using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vagoni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int k = Convert.ToInt32(textBox3.Text);
            int vV = y / x;
            int h = y % x;
            if (h > 0)
            { vV = vV + 1; textBox4.Text = Convert.ToString(vV); } 
            else {textBox4.Text = Convert.ToString(vV); }
            int vP = k / x;
            int Q = k % x;
            if (Q > 0)
            { vP = vP + 1; textBox5.Text = Convert.ToString(vP); }
            else { textBox5.Text = Convert.ToString(vP); }
            if (vP > vV)
            { int p = vP - vV;textBox6.Text = Convert.ToString(p); }
            else { int p = vP - vV; textBox6.Text = Convert.ToString(p); }
        }
    }
}
