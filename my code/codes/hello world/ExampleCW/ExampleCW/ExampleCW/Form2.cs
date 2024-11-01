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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string cs= @"Data Source=AMKDA-PC;Initial catalog=tablorder;Integrated Security=true";
            SqlConnection con=new SqlConnection(cs);
            con.Open();

            string sql = "SELECT Name FROM dbitem";
            SqlCommand com =new SqlCommand(sql, con);

            SqlDataReader dr= com.ExecuteReader();
            while (dr.Read())
            {
                this.cmbitems.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }

        private void cmbitems_SelectedIndexChanged(object sender, EventArgs e) {
            
                string cs = @"Data Source=AMKDA-PC;Initial catalog=tablorder;Integrated Security=true";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "SELECT Price FROM dbitem WHERE Name=@Name";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@Name", this.cmbitems.Text);

                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                this.txtprice.Text = dr.GetValue(0).ToString();
                con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
         String cs= @"Data Source=AMKDA-PC;Initial catalog=tablorder;Integrated Security=true";
            SqlConnection con=new SqlConnection(cs);
            con.Open(); 

            string Sql = "INSERT INTO tborderdetails1 (OID,Items,Price,QTY) VALUES (@OID,@Items,@Price,@QTY)";//assign query windows form
            SqlCommand com = new SqlCommand(Sql, con);

            //bind Function
            com.Parameters.AddWithValue("@OID", this.txtoid.Text);
            com.Parameters.AddWithValue("Items",this.cmbitems.Text);
            com.Parameters.AddWithValue("Price",this.txtprice.Text);
            com.Parameters.AddWithValue("QTY",this.numericUpDown1.Text);

            int ret=com.ExecuteNonQuery();

            if (ret==1)
            {
                MessageBox.Show("Item add Saved", "Information");
            }
            //load data to grid view
            String sql= "SELECT Items,Price,QTY,Price*Qty as total FROM tborderdetails1 WHERE OID=@OID";
            SqlCommand com2 = new SqlCommand(sql, con);
            com2.Parameters.AddWithValue("@OID", this.txtoid.Text);

            SqlDataAdapter dap = new SqlDataAdapter(com2);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double bill = 0.00;
            for (int i=0; i<this.dataGridView1.Rows.Count; i++)
            {
                bill += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            this.txttotprice.Text = bill.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=AMKDA-PC;Initial catalog=tablorder;Integrated Security=true";


            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string sql = "INSERT INTO tbitemdetails(OID,Customer,Email,Bill) VALUES (@orderid,@customer,@email,@bill);"; //assigning query windows form

            SqlCommand com = new SqlCommand(sql, con);

            //bind function
            com.Parameters.AddWithValue("@orderid", this.txtoid.Text);
            //com.Parameters.AddWithValue("@date", this.datetime.Value);
            com.Parameters.AddWithValue("@customer", this.txtcustomer.Text);
            com.Parameters.AddWithValue("@email", this.txtemail.Text);
            com.Parameters.AddWithValue("@bill", this.txttotprice.Text);

            int ret = com.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Order placed!", "Information");
            }
            con.Close();

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Form3 inv = new Form3 (this.txtoid.Text);
            inv.ShowDialog(); //shows as a dialod not as seperate forms

        }
    }
}
