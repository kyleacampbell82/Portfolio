using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioTaxCalculatorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> errorList = new List<string>();
        string errorOutput = "";

        decimal i10 = 0;
        decimal i12 = 0;
        decimal i22 = 0;
        decimal i24 = 0;
        decimal i32 = 0;
        decimal i35 = 0;

        decimal adjustedGrossIncome = 0;
        decimal standardDeduction = 0;
        decimal taxableIncome = 0;
        decimal taxesDue = 0;

        decimal overBracket = 0;


        public decimal AdjustedGrossIncome()
        {
            decimal dA = Validator(box_W2.Text);
            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {
                decimal dB = Validator(box_Rent.Text);
                if (errorList.Count > 0)
                {
                    Error(0);
                }
                else
                {
                    decimal dC = Validator(box_Interest.Text);
                    if (errorList.Count > 0)
                    {
                        Error(0);
                    }
                    else
                    {
                        decimal dD = Validator(box_Pension.Text);
                        if (errorList.Count > 0)
                        {
                            Error(0);
                        }
                        else
                        {
                            adjustedGrossIncome = dA + dB + dC + dD;
                        }
                    }
                }
            }
            return adjustedGrossIncome;
        }

        public decimal TaxableIncome()
        {
            taxableIncome = adjustedGrossIncome - standardDeduction;
            return taxableIncome;
        }


        // Event handler that updates taxable income every time the user leaves focus of one of the input text boxes
        private void DisplayTaxableIncome(object sender, EventArgs e)
        {
            AdjustedGrossIncome();
            string adjustedGrossIncomeStr = $"{'$'}{adjustedGrossIncome}";
            lbl_adjustedGrossIncomeDisplay.Text = adjustedGrossIncomeStr;

            lbl_StandardDeductionDisplay.Text = standardDeduction.ToString();
            
            if (standardDeduction == 0)
            {
                lbl_TaxableIncomeDisplay.Text = "0";
            }
            else
            {
                TaxableIncome();
                lbl_TaxableIncomeDisplay.Text = taxableIncome.ToString();
            }     
        }


        // Takes user inputs and sums taxable income, sets dollar amounts for tax brackets based on radio button selection
        // Then passes to  SelectBracket to process and output the solution
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            AdjustedGrossIncome();
            string sumDisplay = $"{'$'}{taxableIncome}";
            lbl_TaxableIncomeDisplay.Text = sumDisplay;

            SelectBracket(taxableIncome);
            int taxesDueToInt = (int)Math.Round(taxesDue);
            string duesOutputStr = taxesDueToInt.ToString();
            lbl_FedDueDisplay.Text = duesOutputStr;
        }


        //  Setting dolloar amounts of each tax bracket based on IRS 2021 Federal Tax Brackets --
        //  Source https://www.nerdwallet.com/article/taxes/federal-income-tax-brackets
        private void SetFilingStatus(object sender, EventArgs e)
        {

            btn_Calculate.Enabled = true;
            if (rdo_Single.Checked == true)
            {
                i10 = 9950;
                i12 = 40525;
                i22 = 86375;
                i24 = 164925;
                i32 = 209425;
                i35 = 523600;
                standardDeduction = 12550;
                lbl_StandardDeductionDisplay.Text = standardDeduction.ToString();
                if ((adjustedGrossIncome - standardDeduction) > 0)
                {
                    taxableIncome = adjustedGrossIncome - standardDeduction;   
                }
                else
                {
                    taxableIncome = 0;
                }
                lbl_TaxableIncomeDisplay.Text = taxableIncome.ToString();

            }
            if (rdo_Joint.Checked == true)
            {
                i10 = 19900;
                i12 = 81050;
                i22 = 172750;
                i24 = 329850;
                i32 = 418850;
                standardDeduction = 25100;
                lbl_StandardDeductionDisplay.Text = standardDeduction.ToString();
                if ((adjustedGrossIncome - standardDeduction) > 0)
                {
                    taxableIncome = adjustedGrossIncome - standardDeduction;
                }
                else
                {
                    taxableIncome = 0;
                }
                lbl_TaxableIncomeDisplay.Text = taxableIncome.ToString();
            }
            if (rdo_Seperate.Checked == true)
            {
                i10 = 9950;
                i12 = 40525;
                i22 = 86375;
                i24 = 164925;
                i32 = 209425;
                i35 = 314150;
                standardDeduction = 12550;
                lbl_StandardDeductionDisplay.Text = standardDeduction.ToString();
                if ((adjustedGrossIncome - standardDeduction) > 0)
                {
                    taxableIncome = adjustedGrossIncome - standardDeduction;
                }
                else
                {
                    taxableIncome = 0;
                }
                lbl_TaxableIncomeDisplay.Text = taxableIncome.ToString();

            }
            if (rdo_Head.Checked == true)
            {
                i10 = 14200;
                i12 = 54200;
                i22 = 86350;
                i24 = 164900;
                i32 = 209400;
                i35 = 523600;
                standardDeduction = 18800;
                lbl_StandardDeductionDisplay.Text = standardDeduction.ToString();
                if ((adjustedGrossIncome - standardDeduction) > 0)
                {
                    taxableIncome = adjustedGrossIncome - standardDeduction;
                }
                else
                {
                    taxableIncome = 0;
                }
                lbl_TaxableIncomeDisplay.Text = taxableIncome.ToString();
            }
        }


        // Determining which tax bracket it falls under and passing data to correct method below
        public decimal SelectBracket(decimal income)
        {
            if (income <= i10)
            {
                taxesDue = Bracket10(income);               
            }
            else if ((income > i10) && (income <= i12))
            {
                taxesDue = Bracket12(income);         
            }
            else if ((income > i12) && (income <= i22))
            {
                taxesDue = Bracket22(income);
            }
            else if ((income > i22) && (income <= i24))
            {
                taxesDue = Bracket24(income);
            }
            else if ((income > i24) && (income <= i32))
            {
                taxesDue = Bracket32(income);
            }
            else if ((income > i32) && (income <= i35))
            {
                taxesDue = Bracket35(income);
            }
            else if (income > i35)
            {
                taxesDue = Bracket37(income);
            }
            return taxesDue;            
        }


        // Calculations for taxing in the correct brackets.
        decimal c = 0;
        public decimal Bracket10(decimal bracketInput)
        {
            c = bracketInput * .1m;
            return c;
        }

        public decimal Bracket12(decimal bracketInput)
        {
            overBracket = bracketInput - i10;
            c = (overBracket * .12m) + Bracket10(i10);
            return c;
        }

        public decimal Bracket22(decimal bracketInput)
        {
            overBracket = bracketInput - i12;
            c = (overBracket * .22m) + Bracket12(i12);
            return c;
        }

        public decimal Bracket24(decimal bracketInput)
        {
            overBracket = bracketInput - i22;
            c = (overBracket * .24m) + Bracket22(i22);
            return c;
        }

        public decimal Bracket32(decimal bracketInput)
        {
            overBracket = bracketInput - i24;
            c = (overBracket * .32m) + Bracket24(i24);
            return c;
        }

        public decimal Bracket35(decimal bracketInput)
        {
            overBracket = bracketInput - i32;
            c = (overBracket * .35m) + Bracket32(i32);
            return c;
        }

        public decimal Bracket37(decimal bracketInput)
        {
            overBracket = bracketInput - i35;
            c = (overBracket * .37m) + Bracket35(i35);
            return c;
        }


        // Data Validation
        public decimal Validator(string userInput)
        {
            string checkDec = "";
            decimal userDec = 0;
            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            else
            {
                checkDec = userInput;
                if (!(decimal.TryParse(checkDec, out userDec)))
                {
                    Error(1);
                }
            }
            if (errorList.Count > 0)
            {
                Error(0);
            }
            return userDec;
        }


        // Exception Handling
        public void Error(int a)
        {
            if (a == 0)
            {
                errorOutput = String.Join("\n", errorList);
                MessageBox.Show(errorOutput);
            }
            if (a == 1)
            {
                errorList.Add("You must use numbers only.");
            }
            if (a == 2)
            {
                errorList.Add("Input cannot be empty.");
            }
            if (errorList.Count > 0)
                return;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            box_W2.Text = "";
            box_Rent.Text = "";
            box_Interest.Text = "";
            box_Pension.Text = "";
            lbl_TaxableIncomeDisplay.Text = "";
            lbl_FedDueDisplay.Text = "";
            taxableIncome = 0;
            taxesDue = 0;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
