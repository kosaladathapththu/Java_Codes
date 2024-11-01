using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Data
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nor, nod;
            double rcost=0,tcost=0,mcost=0,discount=0;

            if(this.combroom.Text=="Standard")
            {
                rcost = 50;
            }
            else if(this.combroom.Text=="Luxury")
            {
                rcost = 100;
            }

            //Get no of rooms
            nor=Convert.ToInt32(this.nor.Value);

            //No of days
            DateTime cin = Convert.ToDateTime(this.cid.Text);
            DateTime cout=Convert.ToDateTime(this.cod.Text);

            TimeSpan ts=cout-cin;

            nod=ts.Days;

            //Calculate TourCost
            tcost=rcost*nor*nod;

            //meall cost
            if(this.ysno.Checked==true)
            {
                mcost = nod * 20;
                tcost=tcost+mcost;
            }
            //Apply Discount for Saark Countries
            string[] saarc = { "Sri Lanka", "India", "pakistan", "Bangladesh", "Nepal", "Bhutan", "Maldives", "Afghanistan" };
            for (int i = 0; i <8; i++ ) 
            {
                if(this.Combcountry.Text== saarc[i])
                {
                    discount = tcost * 10 / 100;
                    tcost=tcost-discount;
                    break;
                }
            }
            this.txtcost.Text = txtcost.ToString();
        }
    }
}
