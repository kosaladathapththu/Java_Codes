using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace ExampleCW
{
    public partial class Form3 : Form
    {
        string Order_id;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string order_id) : this()
        {
            this.Order_id = order_id;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"D:\NIBM\DSE\A Lessons\New folder\codes\hello world\Frame Work\ExampleCW\ExampleCW\CrystalReport2.rpt";

            string cs = "Data Source=AMKDA-PC;Initial catalog=tablorder;Integrated Security=true";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT tborderdetails.Price * tborderdetails.QTY as bill FROM tbitemdetails LEFT JOIN tborderdetails ON tbitemdetails.OID = tborderdetails.OID WHERE tbitemdetails.OID = @oid";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@oid", this.Order_id);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            // Bind data with the crystal report
            CrystalReport2 rpt = new CrystalReport2();
            rpt.Load(@"D:\NIBM\DSE\A Lessons\New folder\codes\hello world\Frame Work\ExampleCW\ExampleCW\CrystalReport2.rpt");
            rpt.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer1.ReportSource = rpt;

            con.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
