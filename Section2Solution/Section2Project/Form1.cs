using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Error list made global to be passed back and forth 
         * between Validator, click events, and primary method */
        List<string> errorList = new List<string>();
        string errorOutput = "";

        private void btn_Binary_Click(object sender, EventArgs e)
        {
            string baseInputStr = "2";
            BaseConvert(box_Int.Text, baseInputStr, 0);
        }

        private void btn_Hex_Click(object sender, EventArgs e)
        {
            string baseInputStr = "16";
            BaseConvert(box_Int.Text, baseInputStr, 1);
        }

        private void btn_Octal_Click(object sender, EventArgs e)
        {
            string baseInputStr = "8";
            BaseConvert(box_Int.Text, baseInputStr, 0);
        }

        private void btn_Base6_Click(object sender, EventArgs e)
        {
            string baseInputStr = "6";
            BaseConvert(box_Int.Text, baseInputStr, 0);
        }

        private void btn_Base9_Click(object sender, EventArgs e)
        {
            string baseInputStr = "9";
            BaseConvert(box_Int.Text, baseInputStr, 0);
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            string baseInputStr = box_Base.Text;
            if (string.IsNullOrEmpty(baseInputStr))
            {
                Error(3);
                Error(0);
            }
            else
            {
                BaseConvert(box_Int.Text, baseInputStr, 0);
            }
        }

        // Conversion Method
        public void BaseConvert (string iI, string bI, byte hP)
        {
            // Send to Validator
            string intInputStr = iI;
            string baseInputStr = bI;
            byte hexPrompt = hP;
            string msgOutput = "";
            

            // Checking input data
            int intInput = Validator(intInputStr); 
            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {
                int baseInput = Validator(baseInputStr);
                if (errorList.Count > 0)
                {
                    Error(0);
                }
                else
                {
                    // Hexidecimal is false
                    int n = baseInput;
                    if (hexPrompt == 0)
                    {
                        if (baseInput < 2 || baseInput > 16)
                        {
                            Error(2);
                            Error(0);
                        }
                        else
                        {
                            var outputStr = "";
                            while (intInput > 0)
                            {
                                var remainder = intInput % baseInput;
                                var res = Math.Abs(intInput / baseInput);
                                outputStr = remainder + outputStr;

                                intInput = res;
                            }

                            msgOutput = $"{n}{"x"}{outputStr}";
                            lbl_Message.Text = msgOutput;
                        }          
                    }

                    // Hexidecimal is true
                    if (hexPrompt == 1)
                    {
                        var hexStr = "";
                        var characters = "0123456789ABCDEF";

                        while (intInput > 0)
                        {
                            var remainder = intInput % 16;
                            var res = Math.Abs(intInput / 16);
                            hexStr = characters[remainder] + hexStr;

                            intInput = res;
                        }

                        msgOutput = $"{"0x"}{hexStr}";
                        lbl_Message.Text = msgOutput;
                    }
                }
            }
        }

        

        // Validate inputs
        public int Validator(string userInput)
        {
            string checkInt = "";
            int userInt = 0;
            if (string.IsNullOrEmpty(userInput))
            {
                Error(3);
                Error(0);
            }
            else
            {
                checkInt = userInput;
                if (!(int.TryParse(checkInt, out userInt)))
                {
                    Error(1);
                    Error(0);
                }

                if (userInt < 0)
                {
                    Error(4);
                    Error(0);
                }
            }
            return userInt;
        }

        // Errors and Exceptions
        public void Error(int a)
        {
            if (a == 0)
            {
                errorOutput = String.Join("\n", errorList);
                lbl_Message.Text = errorOutput;
            }
            if (a == 1)
            {
                errorList.Add("You must use whole numbers only.");
            }
            if (a == 2)
            {
                errorList.Add("Base number must be between 2 and 16.");
            }
            if (a == 3)
            {
                errorList.Add("Input cannot be empty.");
            }
            if (a == 4)
            {
                errorList.Add("Numbers can not be negative.");
            }
            if (errorList.Count > 0)
                return;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            box_Int.Text = "";
            box_Base.Text = "";
            lbl_Message.Text = "";
            errorList.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void box_Int_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(box_Base.Text)))
            {
                btn_Binary.Enabled = true;
                btn_Hex.Enabled = true;
                btn_Octal.Enabled = true;
                btn_Base6.Enabled = true;
                btn_Base9.Enabled = true;
            }
            else
            {
                btn_Binary.Enabled = false;
                btn_Hex.Enabled = false;
                btn_Octal.Enabled = false;
                btn_Base6.Enabled = false;
                btn_Base9.Enabled = false;
            }
            
        }

        private void box_Base_TextChanged(object sender, EventArgs e)
        {
            btn_Process.Enabled = true;
        }


    }
}
