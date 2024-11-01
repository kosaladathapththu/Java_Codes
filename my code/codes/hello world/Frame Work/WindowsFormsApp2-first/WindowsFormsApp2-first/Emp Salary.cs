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
    public partial class Emp_Salary : Form
    {
        public Emp_Salary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Emp_Salary_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        
         
           

        private void button3_Click(object sender, EventArgs e)
        {
            this.txt1.Clear();
            this.txt2.Clear();
            this.txt3.Clear();
            this.txt4.Clear();
            this.txt5.Clear();
            this.txt6.Clear();
            this.txt7.Clear();
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double bassal, Oth, Otr;
            double allw = 0.00, otmt = 0.00, ns = 0.00;

            bassal = Convert.ToDouble(this.txt2.Text);
            Oth = Convert.ToDouble(this.txt3.Text);
            Otr = Convert.ToDouble(this.txt4.Text);

            if (bassal < 10000)
            {
                allw = 3000;
            }
            else if (bassal < 25000)
            {
                allw = 5000;
            }
            else
            {
                allw = 7500;
            }
            otmt = Oth * Otr;
            ns = bassal + allw + otmt;

            //Display
            this.txt5.Text = allw.ToString();
            this.txt6.Text = otmt.ToString();
            this.txt7.Text = ns.ToString();
        
    }
    }
}
