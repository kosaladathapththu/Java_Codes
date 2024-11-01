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
    public partial class Form1 : Form
    {
        string order_id = "";
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string oid)
        {
            InitializeComponent();
            order_id = oid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=DESKTOP-KSPQ6PI\SQLEXPRESS;
                Initial Catalog=orderdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT *, tblorderdetails.price*tblorderdetails.qty as total " +
                "FROM tblorder LEFT JOIN tblorderdetails " +
                "ON tblorder.oid = tblorderdetails.oid WHERE tblorder.oid =@oid";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@oid", order_id);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            CrystalReport1 rpt2 = new CrystalReport1();
            // set the data source of the report
            rpt2.Load(@"C:\Users\USER\source\repos\WindowsFormsApp25\WindowsFormsApp25\CrystalReport1.rpt");
            rpt2.SetDataSource(ds.Tables[0]);

            // set the report source of the created “crystalReportViewer”
            this.crystalReportViewer1.ReportSource = rpt2;

            //Disconnect
            con.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
