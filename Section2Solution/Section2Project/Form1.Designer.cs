
namespace Section2Project
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
            this.box_Int = new System.Windows.Forms.TextBox();
            this.box_Base = new System.Windows.Forms.TextBox();
            this.btn_Binary = new System.Windows.Forms.Button();
            this.btn_Hex = new System.Windows.Forms.Button();
            this.btn_Octal = new System.Windows.Forms.Button();
            this.btn_Base6 = new System.Windows.Forms.Button();
            this.btn_Base9 = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Int = new System.Windows.Forms.Label();
            this.lbl_Base = new System.Windows.Forms.Label();
            this.btn_Process = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_Int
            // 
            this.box_Int.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Int.Location = new System.Drawing.Point(92, 12);
            this.box_Int.Name = "box_Int";
            this.box_Int.Size = new System.Drawing.Size(444, 29);
            this.box_Int.TabIndex = 0;
            this.box_Int.Text = "Enter an integer number";
            this.box_Int.TextChanged += new System.EventHandler(this.box_Int_TextChanged);
            // 
            // box_Base
            // 
            this.box_Base.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Base.Location = new System.Drawing.Point(92, 47);
            this.box_Base.Name = "box_Base";
            this.box_Base.Size = new System.Drawing.Size(443, 29);
            this.box_Base.TabIndex = 1;
            this.box_Base.Text = "Enter a number between 2 and 16";
            this.box_Base.TextChanged += new System.EventHandler(this.box_Base_TextChanged);
            // 
            // btn_Binary
            // 
            this.btn_Binary.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Binary.Enabled = false;
            this.btn_Binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Binary.Location = new System.Drawing.Point(11, 82);
            this.btn_Binary.Name = "btn_Binary";
            this.btn_Binary.Size = new System.Drawing.Size(100, 40);
            this.btn_Binary.TabIndex = 2;
            this.btn_Binary.Text = "Binary";
            this.btn_Binary.UseVisualStyleBackColor = false;
            this.btn_Binary.Click += new System.EventHandler(this.btn_Binary_Click);
            // 
            // btn_Hex
            // 
            this.btn_Hex.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Hex.Enabled = false;
            this.btn_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hex.Location = new System.Drawing.Point(117, 82);
            this.btn_Hex.Name = "btn_Hex";
            this.btn_Hex.Size = new System.Drawing.Size(100, 40);
            this.btn_Hex.TabIndex = 3;
            this.btn_Hex.Text = "Hex";
            this.btn_Hex.UseVisualStyleBackColor = false;
            this.btn_Hex.Click += new System.EventHandler(this.btn_Hex_Click);
            // 
            // btn_Octal
            // 
            this.btn_Octal.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Octal.Enabled = false;
            this.btn_Octal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Octal.Location = new System.Drawing.Point(223, 82);
            this.btn_Octal.Name = "btn_Octal";
            this.btn_Octal.Size = new System.Drawing.Size(100, 40);
            this.btn_Octal.TabIndex = 4;
            this.btn_Octal.Text = "Octal";
            this.btn_Octal.UseVisualStyleBackColor = false;
            this.btn_Octal.Click += new System.EventHandler(this.btn_Octal_Click);
            // 
            // btn_Base6
            // 
            this.btn_Base6.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Base6.Enabled = false;
            this.btn_Base6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Base6.Location = new System.Drawing.Point(329, 82);
            this.btn_Base6.Name = "btn_Base6";
            this.btn_Base6.Size = new System.Drawing.Size(100, 40);
            this.btn_Base6.TabIndex = 5;
            this.btn_Base6.Text = "Base 6";
            this.btn_Base6.UseVisualStyleBackColor = false;
            this.btn_Base6.Click += new System.EventHandler(this.btn_Base6_Click);
            // 
            // btn_Base9
            // 
            this.btn_Base9.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Base9.Enabled = false;
            this.btn_Base9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Base9.Location = new System.Drawing.Point(435, 82);
            this.btn_Base9.Name = "btn_Base9";
            this.btn_Base9.Size = new System.Drawing.Size(100, 40);
            this.btn_Base9.TabIndex = 6;
            this.btn_Base9.Text = "Base 9";
            this.btn_Base9.UseVisualStyleBackColor = false;
            this.btn_Base9.Click += new System.EventHandler(this.btn_Base9_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_Message.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(12, 171);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(523, 270);
            this.lbl_Message.TabIndex = 7;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Coral;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(329, 128);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 40);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Coral;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(435, 128);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 40);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Int
            // 
            this.lbl_Int.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Int.Location = new System.Drawing.Point(15, 12);
            this.lbl_Int.Name = "lbl_Int";
            this.lbl_Int.Size = new System.Drawing.Size(71, 29);
            this.lbl_Int.TabIndex = 10;
            this.lbl_Int.Text = "Integer";
            this.lbl_Int.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Base
            // 
            this.lbl_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Base.Location = new System.Drawing.Point(12, 47);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(74, 29);
            this.lbl_Base.TabIndex = 11;
            this.lbl_Base.Text = "Base";
            this.lbl_Base.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Process
            // 
            this.btn_Process.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Process.Enabled = false;
            this.btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(12, 128);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(100, 40);
            this.btn_Process.TabIndex = 12;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = false;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.lbl_Base);
            this.Controls.Add(this.lbl_Int);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.btn_Base9);
            this.Controls.Add(this.btn_Base6);
            this.Controls.Add(this.btn_Octal);
            this.Controls.Add(this.btn_Hex);
            this.Controls.Add(this.btn_Binary);
            this.Controls.Add(this.box_Base);
            this.Controls.Add(this.box_Int);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_Int;
        private System.Windows.Forms.TextBox box_Base;
        private System.Windows.Forms.Button btn_Binary;
        private System.Windows.Forms.Button btn_Hex;
        private System.Windows.Forms.Button btn_Octal;
        private System.Windows.Forms.Button btn_Base6;
        private System.Windows.Forms.Button btn_Base9;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Int;
        private System.Windows.Forms.Label lbl_Base;
        private System.Windows.Forms.Button btn_Process;
    }
}

