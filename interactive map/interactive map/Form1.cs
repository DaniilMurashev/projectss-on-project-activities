using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interactive_map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Finish";            
            label3.Text = "Final";
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label2.Text = "Checkpoint 1";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики";
            label13.Text = "Avenida Rudge";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            label2.Text = "Checkpoint 2";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет \n Информационная стойка \n Медицинский пункт";
            label13.Text = "Theatro Municipal";
        }

        private void panel2_Click(object sender, PaintEventArgs e)
        {
            panel2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
         
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label2.Text = "Checkpoint 3";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет";
            label13.Text = "Parque do Ibirapuera";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;
            pictureBox18.Visible = true;
            label2.Text = "Checkpoint 4";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет \n Медицинский пункт";
            label13.Text = "Jardim Luzitania";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
            label2.Text = "Checkpoint 5";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет \n Информационная стойка";
            label13.Text = "Iguatemi";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label2.Text = "Checkpoint 6";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет";
            label13.Text = "Rua Lisboa";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            label2.Text = "Checkpoint 7";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет \n Информационная стойка \n Медицинский пункт";
            label13.Text = "Cemitério da Consolação";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            label2.Text = "Checkpoint 8";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет \n Информационная стойка \n Медицинский пункт";
            label13.Text = "Cemitério da Consolação";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label2.Text = "Race Start";
            label3.Text = "Samba Full Race";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label2.Text = "Race Start";
            label3.Text = "Jongo Half Marathon";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            label2.Text = "Race Start";
            label3.Text = "Capoeira 5km Fun Run";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox14.Image = Image.FromFile(@"C:\Users\student\Pictures\drinks.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\student\Pictures\energy.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\student\Pictures\toilet.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\student\Pictures\info.png");
            pictureBox18.Image = Image.FromFile(@"C:\Users\student\Pictures\medical.png");
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            label2.Text = "Checkpoint 7";
            label3.Text = "Особенности: \n Стенд питья \n Энергетические батончики \n Туалет \n Информационная стойка \n Медицинский пункт";
            label13.Text = "Cemitério da Consolação";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
          
        }
    }
}
