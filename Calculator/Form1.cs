using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void wooman_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = wooman.Image;
        }

        private void rost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float rost1 = Convert.ToInt32(rost.Text);
            float ves1 = Convert.ToInt32(ves.Text);
            float BMI = (ves1 / (rost1 * rost1/100/100));
            label6.Text = Convert.ToString(BMI);
            trackBar1.Value = (int)BMI;
            if(BMI<18.5
                )
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
