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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=DESKTOP-KSPQ6PI\SQLEXPRESS;
            Initial Catalog=orderdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT name FROM tblitems";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                this.cmbItem.Items.Add(dr.GetValue(0));
            }

            con.Close();

        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cs = @"Data Source=DESKTOP-KSPQ6PI\SQLEXPRESS;
            Initial Catalog=orderdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT price FROM tblitems WHERE name=@name";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@name", this.cmbItem.Text);

            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            this.txtPrice.Text =  dr.GetValue(0).ToString();

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=DESKTOP-KSPQ6PI\SQLEXPRESS;
            Initial Catalog=orderdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO tblorderdetails(oid,item,price,qty) VALUES(@id,@item,@price,@qty)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@id", this.txtOID.Text);
            com.Parameters.AddWithValue("@item", this.cmbItem.Text);
            com.Parameters.AddWithValue("@price", this.txtPrice.Text);
            com.Parameters.AddWithValue("@qty", this.nuQty.Value);

            int ret = com.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Item Added to Order", "Information");
            }

            //Load Data to Grid view
            string sql2 = "SELECT item, price, qty, price*qty as total FROM tblorderdetails WHERE oid=@oid";
            SqlCommand com2 = new SqlCommand(sql2, con);
            com2.Parameters.AddWithValue("@oid", this.txtOID.Text);

            SqlDataAdapter dap = new SqlDataAdapter(com2);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bill = 0.00;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                bill += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }

            this.txtBill.Text = bill.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=DESKTOP-KSPQ6PI\SQLEXPRESS;
            Initial Catalog=orderdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO tblorder(oid,odate,customer,email,bill) " +
                "VALUES(@id,@odate,@cus,@email,@bill)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@id", this.txtOID.Text);
            com.Parameters.AddWithValue("@odate", this.dtDate.Text);
            com.Parameters.AddWithValue("@cus", this.txtCustomer.Text);
            com.Parameters.AddWithValue("@email", this.txtEmail.Text);
            com.Parameters.AddWithValue("@bill", this.txtBill.Text);

            int ret = com.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Order Placed", "Information");
            }

            con.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this.txtOID.Text);
            f1.ShowDialog();
        }
    }
}
