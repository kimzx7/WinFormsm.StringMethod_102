using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsm.StringMethod
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double THB_USD(double thb, double rate)
        {
            return thb / rate;
        }

        double USD_THB(double usd, double rate)
        {
            return usd * rate;
        }

        private void THB_to_USD_Click(object sender, EventArgs e)
        {
            double a1 = 0;
            double a2 = 0;
            if (double.TryParse(txtrate.Text, out a1) == false)
            {
                MessageBox.Show("กรอกข้อมูลเป็นตัวเลข", "Error");
                txtrate.Focus();
                txtrate.SelectAll();
                return;
            }
            else if (double.TryParse(txtTHB.Text, out a2) == false)
            {
                MessageBox.Show("กรอกข้อมูลเป็นตัวเลข", "Error");
                txtTHB.Focus();
                txtTHB.SelectAll();
                return;
            }

            double a3 = THB_USD(a2, a1);
            txtUSD.Text = Convert.ToString(a3);



            //double rate = Convert.ToDouble(txtrate.Text);
            //double thb = Convert.ToDouble(txtTHB.Text);
            //double usd = Convert.ToDouble(txtUSD.Text);
            //txtTHB.Text = USD_THB(usd,rate);
        }

        private void USD_to_THB_Click(object sender, EventArgs e)
        {
            double a1 = 0;
            double a2 = 0;
            if (double.TryParse(txtrate.Text, out a1) == false)
            {
                MessageBox.Show("กรอกข้อมูลเป็นตัวเลข", "Error");
                txtrate.Focus();
                txtrate.SelectAll();
                return;
            }
            else if (double.TryParse(txtUSD.Text, out a2) == false)
            {
                MessageBox.Show("กรอกข้อมูลเป็นตัวเลข", "Error");
                txtUSD.Focus();
                txtUSD.SelectAll();
                return;
            }

            double a3 = USD_THB(a2, a1);
            txtTHB.Text = Convert.ToString(a3);
        }
    }
}
