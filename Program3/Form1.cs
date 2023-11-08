using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//K7151
//CIS-199-01
//Program1
//9/29/2022
//This program is a simple program to calculate loan interest, down paym,ent, and redit rating.

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void interestButton_Click(object sender, EventArgs e)
        {
            

            //gave array their values

            double[] creditScore = { 300, 580, 670, 740, 800 };
            string[] rating = { "Poor", "Fair", "Good", "Very Good", "Excellent" };
            double[] loanInterest = { 8.014, 7.373, 7.063, 6.149, 5.9 };


            double[] loanAmount = { 1, 500, 2000, 10000, 100000 };
            double[] downPayment = { 0, .10, .15, .10, .05 };


            double payment;

            double userCredit;

            double userLoanInterest = 0;

            double userBaserate;

            double userLoan = 0;
            double userDownPayment = 0;
            double loanDisplay;

            string creditString;
            creditString = CreditTextBox.Text;

            string loanString;
            loanString = loanTextBox.Text;

            string userRating = "";
            //used if on combobox to apply base rate 

            if (loanComboBox.SelectedIndex == 0)
            {
                userBaserate = 1;
            }
            else if (loanComboBox.SelectedIndex == 1)
            {
                userBaserate = 1.3;
            }
            else if (loanComboBox.SelectedIndex == 2)
            {
                userBaserate = 2;
            }

            //nothing is selected shows up message box
            else
            {
                userBaserate = 1;
                MessageBox.Show("Please enter Insurance Type");
            }
            


            //used nested if to apply the arrays and give the selected value a value to apply in math equations at the bottom


            if (double.TryParse(creditString, out userCredit) && userCredit >= 300 && userCredit <= 850 && double.TryParse(loanString, out userLoan) && userLoan >= 1 && userLoan <= 500000)
            {
                for (int i = 0; i < creditScore.Length; i++)
                {

                    if (userCredit >= creditScore[i])
                    {
                        userRating = rating[i];
                    }
                    if (userCredit >= creditScore[i])
                    {
                        userLoanInterest = loanInterest[i];
                    }
                }

                for (int i = 0; i < loanAmount.Length; i++)
                {
                    if (userLoan >= loanAmount[i])
                    {
                        userDownPayment = downPayment[i];
                    }
                }
            }


            //if nothing is imputed shows error message
            else
            {
                MessageBox.Show("Bad Input");
            }







            //calculate totals for the output labels
 

            loanDisplay = userLoanInterest * userBaserate / 100;
            string outLoanString = $"{loanDisplay:P}";
            loanOutputLabel.Text = outLoanString;

            string userRatingString = $"{userRating}";
            creditOutputLabel.Text = userRatingString;

            payment = userDownPayment * userLoan;
            string paymentString = $"{payment:C}";
            paymentOutputLabel.Text = paymentString;
        }
    }
}
