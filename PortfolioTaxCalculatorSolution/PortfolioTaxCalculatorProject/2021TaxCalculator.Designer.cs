
namespace PortfolioTaxCalculatorProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_W2 = new System.Windows.Forms.TextBox();
            this.box_Rent = new System.Windows.Forms.TextBox();
            this.box_Interest = new System.Windows.Forms.TextBox();
            this.box_Pension = new System.Windows.Forms.TextBox();
            this.rdo_Single = new System.Windows.Forms.RadioButton();
            this.grpBox_FilingStatus = new System.Windows.Forms.GroupBox();
            this.rdo_Head = new System.Windows.Forms.RadioButton();
            this.rdo_Seperate = new System.Windows.Forms.RadioButton();
            this.rdo_Joint = new System.Windows.Forms.RadioButton();
            this.lbl_Rent = new System.Windows.Forms.Label();
            this.lbl_W2 = new System.Windows.Forms.Label();
            this.lbl_Interest = new System.Windows.Forms.Label();
            this.lbl_Pension = new System.Windows.Forms.Label();
            this.lbl_TaxableIncome = new System.Windows.Forms.Label();
            this.lbl_TaxableIncomeDisplay = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_FedDue = new System.Windows.Forms.Label();
            this.lbl_FedDueDisplay = new System.Windows.Forms.Label();
            this.lbl_StandardDeduction = new System.Windows.Forms.Label();
            this.lbl_StandardDeductionDisplay = new System.Windows.Forms.Label();
            this.lbl_adjustedGrossIncome = new System.Windows.Forms.Label();
            this.lbl_adjustedGrossIncomeDisplay = new System.Windows.Forms.Label();
            this.grpBox_FilingStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_W2
            // 
            this.box_W2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_W2.Location = new System.Drawing.Point(203, 12);
            this.box_W2.Name = "box_W2";
            this.box_W2.Size = new System.Drawing.Size(282, 29);
            this.box_W2.TabIndex = 0;
            this.box_W2.Leave += new System.EventHandler(this.DisplayTaxableIncome);
            // 
            // box_Rent
            // 
            this.box_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Rent.Location = new System.Drawing.Point(203, 47);
            this.box_Rent.Name = "box_Rent";
            this.box_Rent.Size = new System.Drawing.Size(282, 29);
            this.box_Rent.TabIndex = 1;
            this.box_Rent.Leave += new System.EventHandler(this.DisplayTaxableIncome);
            // 
            // box_Interest
            // 
            this.box_Interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Interest.Location = new System.Drawing.Point(203, 82);
            this.box_Interest.Name = "box_Interest";
            this.box_Interest.Size = new System.Drawing.Size(282, 29);
            this.box_Interest.TabIndex = 2;
            this.box_Interest.Leave += new System.EventHandler(this.DisplayTaxableIncome);
            // 
            // box_Pension
            // 
            this.box_Pension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Pension.Location = new System.Drawing.Point(203, 117);
            this.box_Pension.Name = "box_Pension";
            this.box_Pension.Size = new System.Drawing.Size(282, 29);
            this.box_Pension.TabIndex = 3;
            this.box_Pension.Leave += new System.EventHandler(this.DisplayTaxableIncome);
            // 
            // rdo_Single
            // 
            this.rdo_Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Single.Location = new System.Drawing.Point(6, 28);
            this.rdo_Single.Name = "rdo_Single";
            this.rdo_Single.Size = new System.Drawing.Size(240, 29);
            this.rdo_Single.TabIndex = 4;
            this.rdo_Single.TabStop = true;
            this.rdo_Single.Text = "Single";
            this.rdo_Single.UseVisualStyleBackColor = true;
            this.rdo_Single.CheckedChanged += new System.EventHandler(this.SetFilingStatus);
            // 
            // grpBox_FilingStatus
            // 
            this.grpBox_FilingStatus.Controls.Add(this.rdo_Head);
            this.grpBox_FilingStatus.Controls.Add(this.rdo_Seperate);
            this.grpBox_FilingStatus.Controls.Add(this.rdo_Joint);
            this.grpBox_FilingStatus.Controls.Add(this.rdo_Single);
            this.grpBox_FilingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_FilingStatus.Location = new System.Drawing.Point(16, 356);
            this.grpBox_FilingStatus.Name = "grpBox_FilingStatus";
            this.grpBox_FilingStatus.Size = new System.Drawing.Size(469, 100);
            this.grpBox_FilingStatus.TabIndex = 5;
            this.grpBox_FilingStatus.TabStop = false;
            this.grpBox_FilingStatus.Text = "Filing Status";
            // 
            // rdo_Head
            // 
            this.rdo_Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Head.Location = new System.Drawing.Point(253, 63);
            this.rdo_Head.Name = "rdo_Head";
            this.rdo_Head.Size = new System.Drawing.Size(210, 29);
            this.rdo_Head.TabIndex = 7;
            this.rdo_Head.TabStop = true;
            this.rdo_Head.Text = "Head of Household";
            this.rdo_Head.UseVisualStyleBackColor = true;
            this.rdo_Head.CheckedChanged += new System.EventHandler(this.SetFilingStatus);
            // 
            // rdo_Seperate
            // 
            this.rdo_Seperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Seperate.Location = new System.Drawing.Point(6, 63);
            this.rdo_Seperate.Name = "rdo_Seperate";
            this.rdo_Seperate.Size = new System.Drawing.Size(240, 29);
            this.rdo_Seperate.TabIndex = 6;
            this.rdo_Seperate.TabStop = true;
            this.rdo_Seperate.Text = "Married Filing Seperately";
            this.rdo_Seperate.UseVisualStyleBackColor = true;
            this.rdo_Seperate.CheckedChanged += new System.EventHandler(this.SetFilingStatus);
            // 
            // rdo_Joint
            // 
            this.rdo_Joint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Joint.Location = new System.Drawing.Point(253, 28);
            this.rdo_Joint.Name = "rdo_Joint";
            this.rdo_Joint.Size = new System.Drawing.Size(210, 29);
            this.rdo_Joint.TabIndex = 5;
            this.rdo_Joint.TabStop = true;
            this.rdo_Joint.Text = "Married Filing Jointly";
            this.rdo_Joint.UseVisualStyleBackColor = true;
            this.rdo_Joint.CheckedChanged += new System.EventHandler(this.SetFilingStatus);
            // 
            // lbl_Rent
            // 
            this.lbl_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rent.Location = new System.Drawing.Point(12, 48);
            this.lbl_Rent.Name = "lbl_Rent";
            this.lbl_Rent.Size = new System.Drawing.Size(185, 29);
            this.lbl_Rent.TabIndex = 5;
            this.lbl_Rent.Text = "Rental Income/Loss";
            this.lbl_Rent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_W2
            // 
            this.lbl_W2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_W2.Location = new System.Drawing.Point(12, 13);
            this.lbl_W2.Name = "lbl_W2";
            this.lbl_W2.Size = new System.Drawing.Size(185, 29);
            this.lbl_W2.TabIndex = 9;
            this.lbl_W2.Text = "W2 Income";
            this.lbl_W2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Interest
            // 
            this.lbl_Interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Interest.Location = new System.Drawing.Point(12, 83);
            this.lbl_Interest.Name = "lbl_Interest";
            this.lbl_Interest.Size = new System.Drawing.Size(185, 29);
            this.lbl_Interest.TabIndex = 10;
            this.lbl_Interest.Text = "Interest Income";
            this.lbl_Interest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Pension
            // 
            this.lbl_Pension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pension.Location = new System.Drawing.Point(12, 118);
            this.lbl_Pension.Name = "lbl_Pension";
            this.lbl_Pension.Size = new System.Drawing.Size(185, 29);
            this.lbl_Pension.TabIndex = 11;
            this.lbl_Pension.Text = "Pension Income";
            this.lbl_Pension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TaxableIncome
            // 
            this.lbl_TaxableIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaxableIncome.Location = new System.Drawing.Point(12, 303);
            this.lbl_TaxableIncome.Name = "lbl_TaxableIncome";
            this.lbl_TaxableIncome.Size = new System.Drawing.Size(185, 29);
            this.lbl_TaxableIncome.TabIndex = 5;
            this.lbl_TaxableIncome.Text = "Taxable Income";
            this.lbl_TaxableIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TaxableIncomeDisplay
            // 
            this.lbl_TaxableIncomeDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_TaxableIncomeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TaxableIncomeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaxableIncomeDisplay.Location = new System.Drawing.Point(203, 303);
            this.lbl_TaxableIncomeDisplay.Name = "lbl_TaxableIncomeDisplay";
            this.lbl_TaxableIncomeDisplay.Size = new System.Drawing.Size(282, 29);
            this.lbl_TaxableIncomeDisplay.TabIndex = 6;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Enabled = false;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(12, 522);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(100, 40);
            this.btn_Calculate.TabIndex = 10;
            this.btn_Calculate.Text = "&Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(279, 522);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 40);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(385, 522);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 40);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_FedDue
            // 
            this.lbl_FedDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FedDue.Location = new System.Drawing.Point(12, 480);
            this.lbl_FedDue.Name = "lbl_FedDue";
            this.lbl_FedDue.Size = new System.Drawing.Size(185, 29);
            this.lbl_FedDue.TabIndex = 17;
            this.lbl_FedDue.Text = "Federal Taxes Due";
            this.lbl_FedDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_FedDueDisplay
            // 
            this.lbl_FedDueDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_FedDueDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_FedDueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FedDueDisplay.Location = new System.Drawing.Point(203, 480);
            this.lbl_FedDueDisplay.Name = "lbl_FedDueDisplay";
            this.lbl_FedDueDisplay.Size = new System.Drawing.Size(282, 29);
            this.lbl_FedDueDisplay.TabIndex = 18;
            // 
            // lbl_StandardDeduction
            // 
            this.lbl_StandardDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StandardDeduction.Location = new System.Drawing.Point(12, 262);
            this.lbl_StandardDeduction.Name = "lbl_StandardDeduction";
            this.lbl_StandardDeduction.Size = new System.Drawing.Size(185, 29);
            this.lbl_StandardDeduction.TabIndex = 19;
            this.lbl_StandardDeduction.Text = "Standard Deduction";
            this.lbl_StandardDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_StandardDeductionDisplay
            // 
            this.lbl_StandardDeductionDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_StandardDeductionDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_StandardDeductionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StandardDeductionDisplay.Location = new System.Drawing.Point(203, 263);
            this.lbl_StandardDeductionDisplay.Name = "lbl_StandardDeductionDisplay";
            this.lbl_StandardDeductionDisplay.Size = new System.Drawing.Size(282, 29);
            this.lbl_StandardDeductionDisplay.TabIndex = 20;
            // 
            // lbl_adjustedGrossIncome
            // 
            this.lbl_adjustedGrossIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adjustedGrossIncome.Location = new System.Drawing.Point(12, 194);
            this.lbl_adjustedGrossIncome.Name = "lbl_adjustedGrossIncome";
            this.lbl_adjustedGrossIncome.Size = new System.Drawing.Size(185, 58);
            this.lbl_adjustedGrossIncome.TabIndex = 21;
            this.lbl_adjustedGrossIncome.Text = "Adjusted Gross Income";
            this.lbl_adjustedGrossIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_adjustedGrossIncomeDisplay
            // 
            this.lbl_adjustedGrossIncomeDisplay.BackColor = System.Drawing.Color.White;
            this.lbl_adjustedGrossIncomeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_adjustedGrossIncomeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adjustedGrossIncomeDisplay.Location = new System.Drawing.Point(203, 223);
            this.lbl_adjustedGrossIncomeDisplay.Name = "lbl_adjustedGrossIncomeDisplay";
            this.lbl_adjustedGrossIncomeDisplay.Size = new System.Drawing.Size(282, 29);
            this.lbl_adjustedGrossIncomeDisplay.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 574);
            this.Controls.Add(this.lbl_adjustedGrossIncome);
            this.Controls.Add(this.lbl_adjustedGrossIncomeDisplay);
            this.Controls.Add(this.lbl_StandardDeduction);
            this.Controls.Add(this.lbl_StandardDeductionDisplay);
            this.Controls.Add(this.lbl_FedDueDisplay);
            this.Controls.Add(this.lbl_FedDue);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_TaxableIncome);
            this.Controls.Add(this.lbl_TaxableIncomeDisplay);
            this.Controls.Add(this.lbl_Pension);
            this.Controls.Add(this.lbl_Interest);
            this.Controls.Add(this.lbl_Rent);
            this.Controls.Add(this.lbl_W2);
            this.Controls.Add(this.grpBox_FilingStatus);
            this.Controls.Add(this.box_Pension);
            this.Controls.Add(this.box_Interest);
            this.Controls.Add(this.box_Rent);
            this.Controls.Add(this.box_W2);
            this.Name = "Form1";
            this.Text = "Tax Calculator 2021";
            this.grpBox_FilingStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_W2;
        private System.Windows.Forms.TextBox box_Rent;
        private System.Windows.Forms.TextBox box_Interest;
        private System.Windows.Forms.TextBox box_Pension;
        private System.Windows.Forms.RadioButton rdo_Single;
        private System.Windows.Forms.GroupBox grpBox_FilingStatus;
        private System.Windows.Forms.RadioButton rdo_Head;
        private System.Windows.Forms.RadioButton rdo_Seperate;
        private System.Windows.Forms.RadioButton rdo_Joint;
        private System.Windows.Forms.Label lbl_Rent;
        private System.Windows.Forms.Label lbl_W2;
        private System.Windows.Forms.Label lbl_Interest;
        private System.Windows.Forms.Label lbl_Pension;
        private System.Windows.Forms.Label lbl_TaxableIncome;
        private System.Windows.Forms.Label lbl_TaxableIncomeDisplay;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_FedDue;
        private System.Windows.Forms.Label lbl_FedDueDisplay;
        private System.Windows.Forms.Label lbl_StandardDeduction;
        private System.Windows.Forms.Label lbl_StandardDeductionDisplay;
        private System.Windows.Forms.Label lbl_adjustedGrossIncome;
        private System.Windows.Forms.Label lbl_adjustedGrossIncomeDisplay;
    }
}

