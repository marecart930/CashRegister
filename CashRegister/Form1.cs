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

        private void printButton_Click(object sender, EventArgs e)

           
        {
            try
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
                change = tendered - total;

                //outputs 

                reciptLabel.Text = $" Whopper King";
                reciptLabel.Text += $"\n Order Number: 1";
                reciptLabel.Text += $"\n\n Febuary 27th";
                reciptLabel.Text += $"\n\n Junior Whopper x{juniorNumber} @ {juniorPrice}";
                reciptLabel.Text += $"\n Double Whopper x{doubleNumber} @ {doublePrice}";
                reciptLabel.Text += $"\n Tripple Whopper x {trippleNumber} @ {tripplePrice}";
                reciptLabel.Text += $"\n\n Subtotal {subTotal.ToString("C")}";
                reciptLabel.Text += $"\n Total {total.ToString("C")}";
                reciptLabel.Text += $"\n Tax {tax.ToString("C")}";
                reciptLabel.Text += $"\n\n Tendered {tendered.ToString("C")}";
                reciptLabel.Text += $"\n Change {change.ToString("C")}";
                reciptLabel.Text += $"\n\n Have a nice day!";
            }
            catch { }
            }

        private void orderButton_Click(object sender, EventArgs e)
        {
            reciptLabel.Text = "";
            subtotalOutput.Text = "";
            totalOutput.Text = "";
            taxOutput.Text = "";
            changeOutput.Text = "";
            juniorInput.Text = "";
            doubleInput.Text = "";
            trippleInput.Text = "";
            tenderedInput.Text = "";
        }

        private void taxOutput_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
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
                change = tendered - total;

                //output
                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch { }
        }

            double taxrate = 0.13;


        private void totalButton_Click(object sender, EventArgs e)
        {
            try
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
            catch { }
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
