using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_first
{
    public partial class Sum_Calculation : Form
    {
        public Sum_Calculation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Sum_Calculation_Load(object sender, EventArgs e)
        {
             
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int no1, no2, sum;
            double avg;

            no1 = Convert.ToInt32(this.textBox1.Text);
            no2 = Convert.ToInt32(this.textBox2.Text);

            sum = no1 + no2;
            avg =sum /2;

            this.textBox3.Text = sum.ToString();
            this.textBox4.Text = avg.ToString();
            
        }

        private void label1trt1_Click(object sender, EventArgs e)
        {

        }
    }
}
