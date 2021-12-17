using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace машина_аренда
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = "Kia Rio";
            foto.Image = Image.FromFile(@"C:\Users\student\source\repos\машина аренда\k5.jpg");
            cena.Text = "1 000 000";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            name.Text = "Kia Optima";
            foto.Image = Image.FromFile(@"C:\Users\student\source\repos\машина аренда\optima.jpg");
            cena.Text = "2 000 000";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            name.Text = "Kia K5";
            foto.Image = Image.FromFile(@"C:\Users\student\source\repos\машина аренда\rio.jpg");
            cena.Text = "3 000 000";
        }
    }
}
