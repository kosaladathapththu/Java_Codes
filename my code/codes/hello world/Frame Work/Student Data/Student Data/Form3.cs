using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Data
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double bs = 0.00, all = 0.00, epf = 0.00, etf = 0.00, ns = 0.00;

            // Check if the basic salary textbox is empty
            if (this.textBox6.Text == "")
            {
                this.errorProvider1.SetError(this.textBox6, "Basic salary Cannot be Blank");
                return; // Early return if basic salary is blank
            }

            // Convert basic salary to double
            bs = Convert.ToDouble(this.textBox6.Text);

            // Allowance Calculation based on selected position
            if (this.comboBox1.SelectedItem.ToString() == "Clerk")
            {
                all = 5000;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Staff")
            {
                all = 7000;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Manager")
            {
                all = 9000;
            }

            // Add extra allowance if checked
            if (this.C.Checked == true)
            {
                all += 5000;
            }

            // EPF and ETF Calculation
            epf = (bs * 12 / 100) + (bs * 8 / 100);
            etf = bs * 3 / 100;

            // Net Salary Calculation
            ns = bs + all - (bs * 8 / 100);

            // Display results in the textboxes
            this.textBox5.Text = all.ToString(); // Display allowance
            this.textBox2.Text = epf.ToString(); // Display EPF
            this.textBox3.Text = etf.ToString(); // Display ETF
            this.textBox4.Text = ns.ToString(); // Display Net Salary
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
