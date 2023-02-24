using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double juniorNumber, doubleNumber, trippleNumber, subTotal, total, tax, tendered, change;

        private void changeButton_Click(object sender, EventArgs e)
        {
            //get inputs
            tendered = Convert.ToDouble(tenderedInput.Text);
            juniorNumber = Convert.ToDouble(juniorInput.Text);
            doubleNumber = Convert.ToDouble(doubleInput.Text);
            trippleNumber = Convert.ToDouble(trippleInput.Text);

            //do calculations
            double juniorPrice = 1.29 * juniorNumber;
            double doublePrice = 3.49 * doubleNumber;
            double tripplePrice = 5.29 * trippleNumber;

            subTotal = juniorPrice + doublePrice + tripplePrice;
            tax = taxrate * subTotal;
            total = subTotal + tax;
            tendered = tendered + tax;
            change = tendered - total;

            //output
            changeOutput.Text = $"{change.ToString("C")}";
        }

        double taxrate = 0.13;


        private void totalButton_Click(object sender, EventArgs e)
        {
            //get inputs
            juniorNumber = Convert.ToDouble(juniorInput.Text);
            doubleNumber = Convert.ToDouble(doubleInput.Text);
            trippleNumber = Convert.ToDouble(trippleInput.Text);
            

            //do calculations
            double juniorPrice = 1.29 * juniorNumber;
            double doublePrice = 3.49 * doubleNumber;
            double tripplePrice = 5.29 * trippleNumber;

            subTotal = juniorPrice + doublePrice + tripplePrice;
            tax = taxrate * subTotal;
            total = subTotal + tax;
            

            //output
            subtotalOutput.Text = $"{subTotal.ToString("C")}";
            totalOutput.Text = $"{total.ToString("C")}";
            taxOutput.Text = $"{tax.ToString("C")}";
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
