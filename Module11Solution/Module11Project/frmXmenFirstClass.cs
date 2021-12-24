using System;
using System.Collections.Generic;
using System.Windows.Forms;

/***************** 
 * Kyle Campbell
 * ITD-1253-60438
 * 23 Nov 2021
 ****************/


namespace Module11Project
{
    public partial class frmXmenFirstClass : Form
    {
        public frmXmenFirstClass()
        {
            InitializeComponent();
        }

        /* Class scope error list to combine all errors 
        * throughout the class and display in a single method. */
        List<string> errorList = new List<string>();
        string errorOutput = "";

        // Class variables to enable/disable GUI features and give feedback to User
        string dataType = "";
        string mathType = "";
        string errorType = "";
        bool byteClick = false;
        bool shortClick = false;
        bool intClick = false;
        bool longClick = false;
        bool floatClick = false;
        bool douClick = false;
        bool decClick = false;

        decimal answer;

        public decimal Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        /* Changes output label text to reflect which data type the user has selected
        * and gives the user additional instructions */
        private void btn_Byte_Click(object sender, EventArgs e)
        {
            dataType = "Type Byte: Enter whole numbers between \n-128 and 127 or\n" +
                "0 and 255\n";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";

            byteClick = true;
            shortClick = intClick = longClick = floatClick = douClick = decClick = false;
        }

        private void btn_Short_Click(object sender, EventArgs e)
        {
            dataType = "Type Short: Enter whole numbers between \n-32,768 and 32,767 or\n" +
                "0 and 65,535\n";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";

            shortClick = true;
            byteClick = intClick = longClick = floatClick = douClick = decClick = false;
        }

        private void btn_Int_Click(object sender, EventArgs e)
        {
            dataType = "Type Int: Enter whole numbers between \n-2,147,483,648 and 2,147,483,647 or\n" +
                "0 and 4,294,967,295\n";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";

            intClick = true;
            byteClick = shortClick = longClick = floatClick = douClick = decClick = false;
        }

        private void btn_Long_Click(object sender, EventArgs e)
        {
            dataType = "Type Long: Enter whole numbers between \n-2,147,483,648 and 2,147,483,647 or\n" +
                "0 and 4,294,967,295 \n";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";

            longClick = true;
            byteClick = shortClick = intClick = floatClick = douClick = decClick = false;
        }

        private void btn_Float_Click(object sender, EventArgs e)
        {
            dataType = "Type Float: Can have up to \n 7 significant digits.\n";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";

            floatClick = true;
            byteClick = shortClick = intClick = longClick = douClick = decClick = false;
        }

        private void btn_Double_Click(object sender, EventArgs e)
        {
            dataType = "Type Double: Can have up to \n 14 significant digits.\n";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";

            douClick = true;
            byteClick = shortClick = intClick = longClick = floatClick = decClick = false;
        }

        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            dataType = "Type Decimal: Can have up to \n 28 significant digits.\n";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";

            decClick = true;
            byteClick = shortClick = intClick = longClick = floatClick = douClick = false;
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            decimal dL = Validator(box_Left.Text);   // Validation line 316
            decimal dR = Validator(box_Right.Text);  // Validation line 316
            string op = "";
            
            // Instantiate and Get/Set for MathFirstClass Methods
            MathFirstClass mathFirstClass = new MathFirstClass();

            // Sending data to MathFirstClass - Line 541
            mathFirstClass.Left = dL;
            mathFirstClass.Right = dR;

            // If/Else for Radio Buttons
            if (rad_Add.Checked == true)
            {
                try
                {
                    answer = mathFirstClass.Add_Operands();
                    op = " + ";
                    PostProcess(dL, dR, answer, op);
                }
                catch (OverflowException) 
                {
                    Error(7);
                    Error(0);
                }   
            }
            else if (rad_Sub.Checked == true)
            {
                try
                {
                    answer = mathFirstClass.Sub_Operands();
                    op = " - ";
                    PostProcess(dL, dR, answer, op);
                }
                catch (OverflowException)
                {
                    Error(7);
                    Error(0);
                }
            }
            else if (rad_Mult.Checked == true)
            {
                try
                {
                    answer = mathFirstClass.Mult_Operands();
                    op = " * ";
                    PostProcess(dL, dR, answer, op);
                }
                catch (OverflowException)
                {
                    Error(7);
                    Error(0);
                }
                
            }
            else if (rad_Div.Checked == true)
            {
                if ((dL == 0) || (dR == 0))
                {
                    Error(5);
                }
                else
                {
                    try
                    {
                        answer = mathFirstClass.Div_Operands();
                        op = " / ";
                        PostProcess(dL, dR, answer, op);
                    }
                    catch (OverflowException) 
                    { 
                        Error(7); 
                        Error(0); 
                    }
                }
            }
            else if (rad_Mod.Checked == true)
            {
                if (dL <= 0 || dR <= 0)
                {
                    Error(6);
                }
                else
                {
                    try
                    {
                        answer = mathFirstClass.Mod_Operands();
                        op = " % ";
                        PostProcess(dL, dR, answer, op);
                    }
                    catch
                    {
                        Error(7);
                        Error(0);
                    }
                    
                }
            }
            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {

            }
        }

        public void PostProcess(decimal left, decimal right, decimal answer, string oP)
        {
            string outputStr = "";

            // If statements for which data type was selected
            if (byteClick == true)
            {
                try
                {
                    byte byteLeft = Decimal.ToByte(left);
                    byte byteRight = Decimal.ToByte(right);
                    byte byteAnswer = Decimal.ToByte(answer);
                    outputStr = $"{byteLeft}{oP}{byteRight}{" = "}{byteAnswer}";
                    lbl_Output.Text = outputStr;
                }
                catch (OverflowException) { Error(2); Error(0); }
            }
            if (shortClick == true)
            {
                try
                {
                    short shortLeft = Decimal.ToInt16(left);
                    short shortRight = Decimal.ToInt16(right);
                    short shortAnswer = Decimal.ToInt16(answer);
                    outputStr = $"{shortLeft}{oP}{shortRight}{" = "}{shortAnswer}";
                    lbl_Output.Text = outputStr;
                }
                catch (OverflowException) { Error(2); Error(0); }
            }
            if (intClick == true)
            {
                try
                {
                    int intLeft = Decimal.ToInt32(left);
                    int intRight = Decimal.ToInt32(right);
                    int intAnswer = Decimal.ToInt32(answer);
                    outputStr = $"{intLeft}{oP}{intRight}{" = "}{intAnswer}";
                    lbl_Output.Text = outputStr;
                }
                catch (OverflowException) { Error(2); Error(0); }
            }
            if (longClick == true)
            {
                try
                {
                    long longLeft = Decimal.ToInt64(left);
                    long longRight = Decimal.ToInt64(right);
                    long longAnswer = Decimal.ToInt64(answer);
                    outputStr = $"{longLeft}{oP}{longRight}{" = "}{longAnswer}";
                    lbl_Output.Text = outputStr;
                }
                catch (OverflowException) { Error(2); Error(0); }
            }
            if (floatClick == true)
            {
                try
                {
                    float floatLeft = (float)left;
                    float floatRight = (float)right;
                    float floatAnswer = (float)answer;
                    outputStr = $"{floatLeft}{oP}{floatRight}{" = "}{floatAnswer}";
                    lbl_Output.Text = outputStr;
                }
                catch (OverflowException) { Error(2); Error(0); }
            }
            if (douClick == true)
            {
                try
                {
                    double doubleLeft = (double)left;
                    double doubleRight = (double)right;
                    double doubleAnswer = (double)answer;
                    outputStr = $"{doubleLeft}{oP}{doubleRight}{" = "}{doubleAnswer}";
                    lbl_Output.Text = outputStr;
                }
                catch (OverflowException) { Error(2); Error(0); }
            }
            if (decClick == true)
            {
                try
                {
                    decimal decimalLeft = left;
                    decimal decimalRight = right;
                    decimal decimalAnswer = answer;
                    outputStr = $"{decimalLeft}{oP}{decimalRight}{" = "}{decimalAnswer}";
                    lbl_Output.Text = outputStr;
                }
                catch (OverflowException) { Error(2); Error(0); }
            }
        }

        // Input Validation
        public decimal Validator(string userInput)
        {
            string checkDec = "";
            decimal userDec = 0;
            if (string.IsNullOrEmpty(userInput))
            {
                Error(3);
            }
            else
            {
                checkDec = userInput;
                if (!(decimal.TryParse(checkDec, out userDec)))
                {
                    Error(1);
                }
            }
            return userDec;
        }

        // Errors and Exceptions
        public void Error(int a)
        {
            if (a == 0)
            {
                errorOutput = String.Join("\n", errorList);
                lbl_Output.Text = errorOutput;
            }
            if (a == 1)
            {
                errorList.Add("You must use numbers only.");
            }
            if (a == 2)
            {
                errorList.Add("Input numbers must be between the minimum and maximum value listed.");
            }
            if (a == 3)
            {
                errorList.Add("Input cannot be empty.");
            }
            if (a == 4)
            {
                errorList.Add("Numbers can not be negative.");
            }
            if (a == 5)
            {
                errorList.Add("Can not divide by zero.");
            }
            if (a == 6)
            {
                errorList.Add("Modulus numbers can not be zero or negative.");
            }
            if (a == 7)
            {
                errorList.Add("The answer is too large for this data type.");
            }
            if (errorList.Count > 0)
                return;
        }


        // Changes output label to reflect what will be done
        private void rad_Add_CheckedChanged(object sender, EventArgs e)
        {
            mathType = "\nAdd Selected: Press Compute to view Sum";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";
        }

        private void rad_Sub_CheckedChanged(object sender, EventArgs e)
        {
            mathType = "\nSubtract Selected: Press Compute to view Difference";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";
        }

        private void rad_Mult_CheckedChanged(object sender, EventArgs e)
        {
            mathType = "\nMultiply Selected: Press Compute to view Product";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";
        }

        private void rad_Div_CheckedChanged(object sender, EventArgs e)
        {
            mathType = "\nDiv Selected: Press Compute to view Quotient";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";
        }

        private void rad_Mod_CheckedChanged(object sender, EventArgs e)
        {
            mathType = "\nModulus Selected: Press Compute to view Remainder";
            lbl_Output.Text = $"{dataType}{mathType}{errorType}";
        }

        /* Validating Decimals and Negative numbers and disabling buttons
         * and radio buttons that do not allow them on the fly */
        private void box_Left_TextChanged(object sender, EventArgs e)
        {
            if (box_Left.Text.Contains("."))
            {
                // Disables buttons
                btn_Byte.Enabled = false;
                btn_Int.Enabled = false;
                btn_Short.Enabled = false;
                btn_Long.Enabled = false;
                rad_Mod.Enabled = false;

                // Sets button click event to false to prevent exception
                byteClick = false;
                shortClick = false;
                intClick = false;
                longClick = false;

                errorType = "\nInteger buttons and Modulus disabled due to decimal.";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
            else
            {
                // Enables or Re-enables if not preset
                btn_Byte.Enabled = true;
                btn_Int.Enabled = true;
                btn_Short.Enabled = true;
                btn_Long.Enabled = true;
                rad_Mod.Enabled = true;
                errorType = "";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
            if (box_Left.Text.Contains("-"))
            {
                // Uncheck and disable
                rad_Mod.Checked = false;
                rad_Mod.Enabled = false;

                errorType = "\nModulus disabled due to negative numbers.";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
            else
            {
                // Check and enable
                rad_Mod.Enabled = true;
                errorType = "";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
        }

        private void box_Right_TextChanged(object sender, EventArgs e)
        {
            if (box_Right.Text.Contains("."))
            {
                // Disables buttons
                btn_Byte.Enabled = false;
                btn_Int.Enabled = false;
                btn_Short.Enabled = false;
                btn_Long.Enabled = false;
                rad_Mod.Enabled = false;

                // Sets button click event to false to prevent exception
                byteClick = false;
                shortClick = false;
                intClick = false;
                longClick = false;

                errorType = "\nInteger buttons and Modulus disabled due to decimal.";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
            else
            {
                // Enables or Re-enables if not preset
                btn_Byte.Enabled = true;
                btn_Int.Enabled = true;
                btn_Short.Enabled = true;
                btn_Long.Enabled = true;
                rad_Mod.Enabled = true;
                errorType = "";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
            if (box_Right.Text.Contains("-"))
            {
                // Uncheck and disable
                rad_Mod.Checked = false;
                rad_Mod.Enabled = false;

                errorType = "\nModulus disabled due to negative numbers.";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
            else
            {
                // Check and enable
                rad_Mod.Enabled = true;
                errorType = "";
                lbl_Output.Text = $"{dataType}{mathType}{errorType}";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // Reset radio buttons
            rad_Add.Checked = false;
            rad_Sub.Checked = false;
            rad_Mult.Checked = false;
            rad_Div.Checked = false;
            rad_Mod.Checked = false;

            // Reset Datatype selection
            byteClick = false;
            shortClick = false;
            intClick = false;
            longClick = false;
            floatClick = false;
            douClick = false;
            decClick = false;

            // Reset lists
            errorList.Clear();

            // Reset text
            box_Right.Text = "";
            box_Left.Text = "";
            dataType = "";
            mathType = "";
            errorType = "";
            box_Left.Focus();
            lbl_Output.Text = "Click a button";
        }
    }

    public class MathFirstClass
    {
        decimal left;
        decimal right;
        decimal answer;      

        public decimal Left
        {
            get { return left; }
            set { left = value; }
        }

        public decimal Right
        {
            get { return right; }
            set { right = value; }
        }


        public decimal Add_Operands()
        {
            answer = Left + Right;
            return answer;
        }

        public decimal Sub_Operands()
        {
            answer = Left - Right;
            return answer;
        }
        
        public decimal Mult_Operands()
        {
            answer = Left * Right;
            return answer;
        }

        public decimal Div_Operands()
        {
            answer = Left / Right;
            return answer;
        }
        public decimal Mod_Operands()
        {
            answer = Left % Right;
            return answer;
        }
    }
}
