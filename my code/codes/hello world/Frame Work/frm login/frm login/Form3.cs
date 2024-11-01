using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace frm_login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial catalog=frmlogin;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sql = "insert into tbluser(uid,uname,pasword) Values(@uid,@un,@pw)";
            SqlCommand com=new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@uid",this.textBox1.Text);
            com.Parameters.AddWithValue("@un", this.textBox2.Text);
            com.Parameters.AddWithValue("@pw", this.textBox3.Text);

            if (this.textBox2.Text==this.textBox3.Text) 
            {
            int ret = com.ExecuteNonQuery();
                if (ret == 1) 
                {
                    MessageBox.Show("Registariton successfull");
                }
                else
                {
                    MessageBox.Show("Password is not match");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
