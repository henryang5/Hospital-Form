using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace ang_henry_hw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double calcStayCharges()
        {
            double totalDailyCharge = (Double.Parse(numDaysTextBox.Text) * 350);

            return totalDailyCharge; 
        }

        private double calcMiscCharges()
        {
            double miscCharge = (Double.Parse(medicationChargesTextBox.Text) +
                                                Double.Parse(surgicalChargesTextBox.Text) +
                                                Double.Parse(labFeesTextBox.Text) +
                                                Double.Parse(rehabChargestextBox.Text));
            return miscCharge;
        }

        private double calcTotalCharges()
        {
              double sumCharges = calcStayCharges() + calcMiscCharges();
              return sumCharges;
        }

        private double averageDailyCharges()
        {
            double averageCharges = calcTotalCharges() / (Double.Parse(numDaysTextBox.Text));
            return averageCharges;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            totalDailyChargeTextBox.Text = (calcStayCharges()).ToString("C");
            miscellaneousTextBox.Text = (calcMiscCharges()).ToString("C");
            sumAllChargeTextBox.Text = (calcTotalCharges()).ToString("C");
            averageDailyBillTextBox.Text = (averageDailyCharges()).ToString("C");
       
            outputPanel.Visible = true; 
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // calls set to default method to reset value to orginial state
            setToDefault();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close(); 
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
           AboutForm about = new AboutForm();
           about.ShowDialog(); 
        }

        private void setToDefault()
        {
            // set all text box to null. output not visible. focus to nametextbox
            nameTextBox.Text = null;
            emailTextBox.Text = null;
            telephoneTextBox.Text = null;
            numDaysTextBox.Text = null;
            medicationChargesTextBox.Text = null;
            surgicalChargesTextBox.Text = null;
            labFeesTextBox.Text = null;
            rehabChargestextBox.Text = null;
            totalDailyChargeTextBox.Text = null;
            miscellaneousTextBox.Text = null;
            sumAllChargeTextBox.Text = null;
            averageDailyBillTextBox.Text = null;

            outputPanel.Visible = false;

            nameTextBox.Select();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // calls set to default method to reset value to orginial state
            setToDefault(); 
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name.",
                                    "Null Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button1);
                e.Cancel = true; 
            }
            else
            {
                e.Cancel = false; 
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please enter a email.",
                                    "Null Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else
            {
                Regex emailPattern = new Regex("[A-Za-z0-9._ % +-]+@[A-Za-z0-9.-]+.[A-Za-z]{2,4}");
                if (emailPattern.IsMatch(emailTextBox.Text))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid email.",
                                        "Invalid email",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void telephoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (telephoneTextBox.Text == "")
            {
               // can be null
            }
                
            else
            {
                Regex phoneNumpattern = new Regex("[0-9]{3}.[0-9]{3}.[0-9]{4}");
                if (phoneNumpattern.IsMatch(telephoneTextBox.Text))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid phone number.",
                                        "Invalid phone number",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void numDaysTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (numDaysTextBox.Text == "")
                {
                    MessageBox.Show("Please enter number of days.",
                                        "Null Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                    e.Cancel = true;
                }
                else
                {
                    int numDays = int.Parse(numDaysTextBox.Text);
                    if (numDays <= 0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please enter a integer greater than 0.",
                                        "Invalid range",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
            }
            catch (FormatException exFormat)
            {
                e.Cancel = true;
                MessageBox.Show(exFormat.Message, "Format Exception"); 
            }  
        }

        private void medicationChargesTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string dollarSign = medicationChargesTextBox.Text;
                if (medicationChargesTextBox.Text == "")
                {
                    MessageBox.Show("Please enter medication charges",
                                        "Null Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                    e.Cancel = true;
                }
                else
                {
                    if (dollarSign.StartsWith("$"))
                    {
                        e.Cancel = false;
                        string medCost = dollarSign.Remove(0,1);
                        double medication = double.Parse(medCost);
                        if (medication <= 0.0)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Please enter a value greater than 0.0",
                                            "Invalid range",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation,
                                         MessageBoxDefaultButton.Button1);
                        }
                        medicationChargesTextBox.Text = medCost;
                    }
                    else if (double.Parse(medicationChargesTextBox.Text) <= 0.0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please enter a value greater than 0.0",
                                        "Invalid range",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                 }

            }
            catch (FormatException exFormat)
            {
                e.Cancel = true;
                MessageBox.Show(exFormat.Message, "Format Exception");
            }
        }

        private void surgicalChargesTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string dollarSign = surgicalChargesTextBox.Text;
                if (surgicalChargesTextBox.Text == "")
                {
                    // can be null 
                    surgicalChargesTextBox.Text = "0";
                    e.Cancel = false;
                }
                else
                {
                    if (dollarSign.StartsWith("$"))
                    {
                        e.Cancel = false;
                        string surgCost = dollarSign.Remove(0, 1);
                        double surgical = double.Parse(surgCost);
                        if (surgical < 0.0)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Please enter a value greater than 0.0",
                                            "Invalid range",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation,
                                         MessageBoxDefaultButton.Button1);
                        }
                        surgicalChargesTextBox.Text = surgCost;
                    }
                    else if (double.Parse(surgicalChargesTextBox.Text) < 0.0)
                    {
                        e.Cancel = false;
                        surgicalChargesTextBox.Text = "0";
                    }
                    else
                    {

                        e.Cancel = false;
                    }
                }
            }
            catch (FormatException)
            {
                e.Cancel = false;
                surgicalChargesTextBox.Text = "0";
            }
        }

        private void labFeesTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string dollarSign = labFeesTextBox.Text;
                if (labFeesTextBox.Text == "")
                {
                    MessageBox.Show("Please enter medication charges",
                                        "Null Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                    e.Cancel = true;
                }
                else
                {
                    if (dollarSign.StartsWith("$"))
                    {
                        e.Cancel = false;
                        string labCost = dollarSign.Remove(0, 1);
                        double lab = double.Parse(labCost);
                        if (lab < 0.0)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Please enter a value greater than 0.0",
                                            "Invalid range",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation,
                                         MessageBoxDefaultButton.Button1);
                        }
                        labFeesTextBox.Text = labCost;
                    }
                    else if (double.Parse(labFeesTextBox.Text) < 0.0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please enter a value greater than 0.0",
                                        "Invalid range",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation,
                                     MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
            }
            catch (FormatException exFormat)
            {
                e.Cancel = true;
                MessageBox.Show(exFormat.Message, "Format Exception");
            }
        }

        private void rehabChargestextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string dollarSign = rehabChargestextBox.Text;
                if (rehabChargestextBox.Text == "")
                {
                    // can be null 
                    rehabChargestextBox.Text = "0";
                    e.Cancel = false;
                }
                else
                {
                    if (dollarSign.StartsWith("$"))
                    {
                        e.Cancel = false;
                        string rehabCost = dollarSign.Remove(0, 1);
                        double rehab = double.Parse(rehabCost);
                        if (rehab < 0.0)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Please enter a value greater than 0.0",
                                            "Invalid range",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation,
                                         MessageBoxDefaultButton.Button1);
                        }
                        rehabChargestextBox.Text = rehabCost;
                    }
                    else if (double.Parse(rehabChargestextBox.Text) < 0.0)
                    {
                        e.Cancel = false;
                        rehabChargestextBox.Text = "0";
                    }
                    else
                    {

                        e.Cancel = false;
                    }
                }
            }
            catch (FormatException)
            {
                e.Cancel = false;
                rehabChargestextBox.Text = "0";
            }
        }
    }
}
