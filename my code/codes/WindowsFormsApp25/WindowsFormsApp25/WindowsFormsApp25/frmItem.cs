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

namespace WindowsFormsApp25
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=DESKTOP-KSPQ6PI\SQLEXPRESS;
            Initial Catalog=orderdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT max(icode) FROM tblitems";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read())
            {
                if (dr.GetValue(0).ToString() == "")
                {
                    this.txtITCode.Text = "1";
                }
                else
                {
                    this.txtITCode.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();
                }
            }
            else
            {
                this.txtITCode.Text = "1";
            }

            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=DESKTOP-KSPQ6PI\SQLEXPRESS;
            Initial Catalog=orderdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO tblitems(name,price) VALUES(@name,@price)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@name", this.txtName.Text);
            com.Parameters.AddWithValue("@price", this.nuPrice.Value);

            int ret = com.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Item Saved", "Information");
            }

            con.Close();

            //Call to Load Event
            frmItem_Load(this, null);            

        }
    }
}
