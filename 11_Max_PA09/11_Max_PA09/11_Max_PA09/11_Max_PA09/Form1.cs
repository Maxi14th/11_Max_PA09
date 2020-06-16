using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Max_PA09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {


            double AmountEntered;
            double convertedvalue;

            if ((rdbusdollar.Checked == false) || (rdbjapaneseyen.Checked = false))
            {
                txtconvertedamount.Text = "Select at least one type of currency to convert.";
            }


            try
            {
                if (rdbusdollar.Checked == true)
                {


                    AmountEntered = double.Parse(txtamount.Text);
                    convertedvalue = AmountEntered * 0.74;

                    txtconvertedamount.Text = convertedvalue.ToString();
                }

                else if (rdbjapaneseyen.Checked == true)
                {
                    AmountEntered = double.Parse(txtamount.Text);
                    convertedvalue = AmountEntered * 81.97;

                    txtconvertedamount.Text = convertedvalue.ToString();
                }
            }





            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount.");
            }


        }

            private void btnclear_Click(object sender, EventArgs e)
            {
                txtconvertedamount.Text = " ";
            }
        }
    }
    
    










