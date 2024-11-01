using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frm_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial catalog=frmlogin;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "Select*From tbluser WHERE Uname=@un AND pasword=@pw";
            SqlCommand com = new SqlCommand(sql,con);
            com.Parameters.AddWithValue("@un",this.textBox1.Text);
            com.Parameters.AddWithValue("@pw",this.textBox2.Text);

            SqlDataReader dr=com.ExecuteReader();
            if(dr.Read()==true)
            {
                Form2 home=new Form2();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Pasword", "error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.error1.Text = "Invalid User or Paswword";
            }
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void lblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
