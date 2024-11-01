using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, RoutedEventArgs e)
        {
            int sm, mm, eng;
            double avg = 0.00;
            string grade = "";

            sm=Convert.ToInt32(this.txtSM.Text);
            mm = Convert.ToInt32(this.txtMM.Text);
            eng=Convert.ToInt32(this.txtENG.Text);

            avg=(sm+mm+eng)/3.00;
            if(avg < 50)
            {
                grade = "Fail";
            }
            else
            {
                grade = "Pass";
            }

            this.txtavg.Text=avg.ToString();
            this.txtgrade.Text = grade;


        }
    }
}
