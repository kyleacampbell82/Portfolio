using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section2LabProject
{
    public partial class Section2Lab : Form
    {
        public Section2Lab()
        {
            InitializeComponent();
        }

        // Open Variables
        List<string> errorList = new List<string>();
        string mod1_Str;
        string mod2_Str;
        int mod1_Int;
        int mod2_Int;
        string factStr = "";
        int factInt;
        string fibStr = "";
        int fibInt;
        string errorOut = "";

        /*******  Modulus Section  *******/
        // Show
        public void btn_ModShow_Click(object sender, EventArgs e)
        {
            box_2.Show();
            lbl_Output.Text = "Use 2 whole numbers to find the Modulus.\n" +
                "The first number needs to be larger.";
            btn_ModDo.Enabled = true;
            btn_FactDo.Enabled = false;
            btn_FibDo.Enabled = false;
        }

        // Do
        private void btn_ModDo_Click(object sender, EventArgs e)
        {
            errorList.Clear();
            mod1_Str = box_1.Text;
            mod2_Str = box_2.Text;
            mod1_Int = Validator(mod1_Str);
            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {
                mod2_Int = Validator(mod2_Str);
                if (errorList.Count > 0)
                {
                    Error(0);
                }
                else
                {
                    Modulus(mod1_Int, mod2_Int);
                    if (errorList.Count > 0)
                    {
                        Error(0);
                    }
                }
            }
        }

        // Method
        public void Modulus(int int1, int int2)
        {
            int int1_Copy = int1;
            int iterCount = 0;
            while ((int1 - int2) > -1)
            {
                int1 = int1 - int2;
                iterCount += 1;
            }
            int answer = iterCount;
            string modOutText = $"{int1_Copy}{" % "}{int2}{" = "}{answer}{"\n"}{"With a remainder of "}{int1}";
            lbl_Output.Text = modOutText;
        }


        /*******  Factorial Section *******/
        // Show
        private void btn_FactShow_Click(object sender, EventArgs e)
        {
            box_2.Hide();
            lbl_Output.Text = "Use 1 whole number to find the Factorial.\n";
            btn_ModDo.Enabled = false;
            btn_FactDo.Enabled = true;
            btn_FibDo.Enabled = false;
        }

        // Do
        private void btn_FactDo_Click(object sender, EventArgs e)
        {
            errorList.Clear();
            factStr = box_1.Text;
            factInt = Validator(factStr);
            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {
                if (factInt == 1)
                {
                    Error(5);
                }
                else
                {
                    if (factInt == 0)
                    {
                        Error(6);
                    }
                }
                if (errorList.Count > 0)
                {
                    Error(0);
                }
                else
                {
                    Factorial(factInt);
                }
            }

        }

        // Method
        private void Factorial(int a)
        {
            int aCopy = a;
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            int answer = result;
            string factOutText = $"{"The answer to "}{aCopy}{"! is "}{answer}";
            lbl_Output.Text = factOutText;
        }

        /*******  Fibonacci Section *******/
        // Show
        private void btn_FibShow_Click(object sender, EventArgs e)
        {
            box_2.Hide();
            lbl_Output.Text = "Use 1 whole number to find the Fibonacci.\n";
            btn_ModDo.Enabled = false;
            btn_FactDo.Enabled = false;
            btn_FibDo.Enabled = true;
        }

        // Do
        private void btn_FibDo_Click(object sender, EventArgs e)
        {
            errorList.Clear();
            fibStr = box_1.Text;
            fibInt = Validator(fibStr);
            if (errorList.Count > 0)
            {
                Error(0);
            }
            else
            {
                int fibAnswer = Fibonacci(fibInt);
                if (fibInt == 1)
                {
                    lbl_Output.Text = $"{"Fibonacci(1) = 1"}";
                }
                else
                {
                    if (fibAnswer == 0)
                    {
                        lbl_Output.Text = $"{"Fibonacci(0) = 0"}";
                    }
                    else
                    {
                        if (errorList.Count > 0)
                        {
                            Error(0);
                        }
                        else
                        {

                            int fibA = fibInt - 1;
                            int fibB = fibInt - 2;
                            int fibC = fibInt;
                            int fibF1 = Fibonacci(fibInt - 1);
                            int fibF2 = Fibonacci(fibInt - 2);
                            lbl_Output.Text = $"{"Fibonacci("}{fibC}{") "}{"= "}{"Fibonacci("}{fibA}{") "}{"+"}{"Fibonacci("}{fibB}{")"}{" = "}{fibF1}{" + "}{fibF2}{" = "}{fibAnswer}";
                        }
                    }
                }
            }

        }


        // Method
        public static int Fibonacci(int fibNum)
        {
            if (fibNum == 0) return 0;
            else if (fibNum == 1) return 1;
            else
            {
                return Fibonacci(fibNum - 1) + Fibonacci(fibNum - 2);
            }
        }

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

        public void Error(int a)
        {
            if (a == 0)
            {
                errorOut = String.Join("\n", errorList);
                lbl_Output.Text = errorOut;
            }
            if (a == 1)
            {
                errorList.Add("You must use numbers only.");
            }
            if (a == 2)
            {
                errorList.Add("You number is too large.");
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
                errorList.Add("You can not factorial the number 1.");
            }
            if (a == 6)
            {
                errorList.Add("You can not use the number 0.");
            }
            if (a == 7)
            {
                errorList.Add("You can not use decimals.");
            }
            if (errorList.Count > 0)
                return;
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_Output.Text = "";
            errorList.Clear();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            lbl_Output.Text = "Thank you for using the program";
            this.Close();
        }


        // All style coding from here on

        // Mod Buttons
        private void btn_ModDo_MouseHover(object sender, EventArgs e)
        {
            btn_ModDo.BackColor = Color.FromArgb(250, 181, 65);
            btn_ModDo.ForeColor = Color.Black;
        }

        private void btn_ModDo_MouseLeave(object sender, EventArgs e)
        {
            btn_ModDo.BackColor = Color.Black;
            btn_ModDo.ForeColor = Color.FromArgb(250, 181, 65); 
        }

        private void btn_ModShow_MouseHover(object sender, EventArgs e)
        {
            btn_ModShow.BackColor = Color.FromArgb(250, 181, 65);
            btn_ModShow.ForeColor = Color.Black;
        }

        private void btn_ModShow_MouseLeave(object sender, EventArgs e)
        {
            btn_ModShow.BackColor = Color.Black;
            btn_ModShow.ForeColor = Color.FromArgb(250, 181, 65);
        }

        // Factorial Buttons
        private void btn_FactDo_MouseHover(object sender, EventArgs e)
        {
            btn_FactDo.BackColor = Color.FromArgb(57, 255, 20);
            btn_FactDo.ForeColor = Color.Black;
        }

        private void btn_FactDo_MouseLeave(object sender, EventArgs e)
        {
            btn_FactDo.BackColor = Color.Black;
            btn_FactDo.ForeColor = Color.FromArgb(57, 255, 20);
        }

        private void btn_FactShow_MouseHover(object sender, EventArgs e)
        {
            btn_FactShow.BackColor = Color.FromArgb(57, 255, 20);
            btn_FactShow.ForeColor = Color.Black;
        }

        private void btn_FactShow_MouseLeave(object sender, EventArgs e)
        {
            btn_FactShow.BackColor = Color.Black;
            btn_FactShow.ForeColor = Color.FromArgb(57, 255, 20);
        }

        // Fibonacci Buttons
        private void btn_FibDo_MouseHover(object sender, EventArgs e)
        {
            btn_FibDo.BackColor = Color.FromArgb(17, 255, 238);
            btn_FibDo.ForeColor = Color.Black;
        }

        private void btn_FibDo_MouseLeave(object sender, EventArgs e)
        {
            btn_FibDo.BackColor = Color.Black;
            btn_FibDo.ForeColor = Color.FromArgb(17, 255, 238);
        }

        private void btn_FibShow_MouseHover(object sender, EventArgs e)
        {
            btn_FibShow.BackColor = Color.FromArgb(17, 255, 238);
            btn_FibShow.ForeColor = Color.Black;
        }

        private void btn_FibShow_MouseLeave(object sender, EventArgs e)
        {
            btn_FibShow.BackColor = Color.Black;
            btn_FibShow.ForeColor = Color.FromArgb(17, 255, 238);
        }

        // Control Buttons
        private void btn_Clear_MouseHover(object sender, EventArgs e)
        {
            btn_Clear.BackColor = Color.FromArgb(255, 7, 58);
            btn_Clear.ForeColor = Color.Black;
        }

        private void btn_Clear_MouseLeave(object sender, EventArgs e)
        {
            btn_Clear.BackColor = Color.Black;
            btn_Clear.ForeColor = Color.FromArgb(255, 7, 58);
        }

        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.FromArgb(255, 7, 58);
            btn_Exit.ForeColor = Color.Black;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Black;
            btn_Exit.ForeColor = Color.FromArgb(255, 7, 58);
        }
    }
}
