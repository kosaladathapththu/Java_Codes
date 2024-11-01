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
    public partial class Form3 : Form
    {
        string Order_id;
        public Form3(string orderID)
        {
            InitializeComponent();
            this.Order_id = orderID;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource= @"D:\NIBM\DSE\A Lessons\New folder\codes\hello world\Frame Work\ExampleCW\ExampleCW\CrystalReport1.rpt";

            string cs= "Data Source=AMKDA-PC;Initial catalog=tablorder;Integrated Security=true";

            SqlConnection con = new SqlConnection();
            con.Open();

            string sql = "SELECT * tborderdetails.Price * tborderdetails.QTY as bill FROM tbitemdetails LEFT JOIN tborderdetails ON tbitemdetails.OID=tborderdetails.OID WHERE tbitemdetails.OID=@oid";
                 SqlCommand com=new SqlCommand(sql,con);
            com.Parameters.AddWithValue("@oid", this.Order_id);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //bind data with the crystal report

            CrystalReport1 rpt = new CrystalReport1();
            rpt.Load(@"D:\NIBM\DSE\A Lessons\New folder\codes\hello world\Frame Work\ExampleCW\ExampleCW\CrystalReport1.rpt");
            rpt.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer1.ReportSource = rpt;

            con.Close();


        }
    }
}
