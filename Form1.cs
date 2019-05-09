using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Login
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
            SqlConnection con = new SqlConnection(@"Data Source=20-PC\SQLEXPRESS;Initial Catalog=Student_Portal;Integrated Security=True");
            string query = "Select * from Login1 Where Name= '"+textBox1.Text+"'and Class='"+textBox2.Text+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query,con);

            DataTable dtbl = new DataTable();

            adapter.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login failed");

            }
           
        }
    }
}
