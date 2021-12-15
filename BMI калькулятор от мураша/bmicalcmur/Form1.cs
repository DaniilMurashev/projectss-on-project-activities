using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmicalcmur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rostBox.Clear();
            vesBox.Clear();
            label13.Text = "";
            pictureBox4.Image = null;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox2.Image;

            double rost = Double.Parse(rostBox.Text);
            double ves = Double.Parse(vesBox.Text);

            double itog = ves / ((rost / 100) * (rost / 100));
            label13.Text = itog.ToString("##.##");

            trackBar1.Value = Convert.ToInt32(itog);

            if (itog < 12)
            {
                pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\bmi-underweight-icon.png");
                label1.Text = "Недостаточный";
            }
            else
            {
                if (itog < 25)
                {
                    pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\bmi-healthy-icon.png");
                    label1.Text = "Здоровый";
                }
                else
                {
                    if (itog < 38)
                    {
                        pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\bmi-overweight-icon.png");
                        label1.Text = "Избыточный";
                    }
                    else
                    {
                        pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\bmi-obese-icon.png");
                        label1.Text = "Ожирение";
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox3.Image;

            double rost1 = Double.Parse(rostBox.Text);
            double ves1 = Double.Parse(vesBox.Text);

            double itog1 = ves1 / ((rost1 / 100) * (rost1 / 100));
            label13.Text = itog1.ToString("##.##");

            trackBar1.Value = Convert.ToInt32(itog1);

            if (itog1 < 12)
            {
                pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\hud-woman.png");
                label1.Text = "Недостаточный";
            }
            else
            {
                if (itog1 < 25)
                {
                    pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\female-icon.png");
                    label1.Text = "Здоровый";
                }
                else
                {
                    if (itog1 < 38)
                    {
                        pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\izb-woman.png");
                        label1.Text = "Избыточный";
                    }
                    else
                    {
                        pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\Малинин 31КС\tolst-woman.png");
                        label1.Text = "Ожирение";
                    }
                }
            }
        }
    }   
}
