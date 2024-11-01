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

namespace report2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"D:\NIBM\DSE\A Lessons\New folder\codes\hello world\Frame Work\report2\report2\CrystalReport1.rpt";
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC; Initial Catalog=frmlogin;Integrated Security=True";
            SqlConnection con=new SqlConnection(cs);
            con.Open();

            string sql = "SELECT*From tbluser Where uid=@id";
            SqlCommand com=new SqlCommand(sql, con);
            com.Parameters.AddWithValue(@"id",this.textBox1.Text);

            SqlDataAdapter dap= new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            CrystalReport1 report2= new CrystalReport1();

            //set the Data sourse of the Report
            report2.Load(@"D:\NIBM\DSE\A Lessons\New folder\codes\hello world\Frame Work\report2\report2\CrystalReport1.rpt");
            report2.SetDataSource(ds.Tables[0]);

            //set the Data report Sourse of the Created "CrystelReportViewer"
            this.crystalReportViewer1.ReportSource= report2;

            //disconnect
            con.Close();
        }
    }
}
