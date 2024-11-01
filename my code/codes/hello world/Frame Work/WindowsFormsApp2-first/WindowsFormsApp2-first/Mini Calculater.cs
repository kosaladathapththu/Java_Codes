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
    public partial class Mini_Calculater : Form
    {
        string op;
        double no1, no2, ans;
        public Mini_Calculater()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = txtdisplay.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = this.txtdisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text=this.txtdisplay.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text= this.txtdisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text=this.txtdisplay.Text+"5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = this.txtdisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text=this.txtdisplay.Text+ "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = this.txtdisplay.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = this.txtdisplay.Text + "9";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            no1=Convert.ToDouble(this.txtdisplay.Text);
            op = "-";
            this.txtdisplay.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(this.txtdisplay.Text);
            op = "/";
            this.txtdisplay.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(this.txtdisplay.Text);
            op = "*";
            this.txtdisplay.Clear();
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToDouble(this.txtdisplay.Text);
            if (op == "+")
            {
                ans = no1 + no2;
            }
            if (op == "-")
            {
                ans = no1 - no2;
            }
            if (op == "*")
            {
                ans = no1 * no2;
            }
            if (op == "/")
            {
                ans = no1 / no2;
            }
            this.txtdisplay.Text = ans.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (this.txtdisplay.Text != "")
            {
                this.txtdisplay.Text = this.txtdisplay.Text + "0";
            }
        }

        private void btnplu_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(this.txtdisplay.Text);
            op = "+";
            this.txtdisplay.Clear();

        }
    }
}
