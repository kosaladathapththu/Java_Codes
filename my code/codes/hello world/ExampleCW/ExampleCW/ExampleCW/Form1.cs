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

namespace ExampleCW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void udprice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial Catalog=tablorder;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "SELECT MAX(ITCode) FROM dbitem";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (dr.GetValue(0).ToString() == "")
                {
                    this.txtcode.Text = "1";
                }
                else
                {
                    this.txtcode.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();
                }
            }
            else
            {
                this.txtcode.Text = "1";
            }
            con.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial Catalog=tablorder;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO dbitem(name, price) VALUES(@name, @price)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@price", this.udprice.Value); // Corrected line
            com.Parameters.AddWithValue("@name", this.txtname.Text);

            int ret = com.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Item Saved", "Information");
            }
            con.Close();

            // Call to Load Event
            Form1_Load(this, null);
        }
    }
}
