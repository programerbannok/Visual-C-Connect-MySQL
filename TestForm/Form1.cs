using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(" datasource=localhost;port=3306;Initial Catalog='visual_studio';username=root;password= ");
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connect successfully");
            }
            else
            {
                MessageBox.Show("Connection failed");

            }
        }
    }
}
