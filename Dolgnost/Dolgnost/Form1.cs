using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgnost
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Dolgnost\Dolgnost\Dolgnost1.mdf;Integrated Security=True");
            sqlConnection.Open();
            if(sqlConnection.State==ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено!");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }
    }
}
