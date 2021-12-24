
namespace Section3WeeksProject
{
    partial class StringStats
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
            this.box_Input = new System.Windows.Forms.TextBox();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.box_List = new System.Windows.Forms.TextBox();
            this.lbl_List = new System.Windows.Forms.Label();
            this.btn_Stats = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.grpBox_WordLists = new System.Windows.Forms.GroupBox();
            this.rdo_WordPairs = new System.Windows.Forms.RadioButton();
            this.rdo_Words = new System.Windows.Forms.RadioButton();
            this.chkBox_Unique = new System.Windows.Forms.CheckBox();
            this.grpBox_Unique = new System.Windows.Forms.GroupBox();
            this.chkBox_Frequency = new System.Windows.Forms.CheckBox();
            this.btn_ShowList = new System.Windows.Forms.Button();
            this.lbl_Stats = new System.Windows.Forms.Label();
            this.box_Stats = new System.Windows.Forms.TextBox();
            this.grpBox_WordLists.SuspendLayout();
            this.grpBox_Unique.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_Input
            // 
            this.box_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Input.Location = new System.Drawing.Point(12, 39);
            this.box_Input.Multiline = true;
            this.box_Input.Name = "box_Input";
            this.box_Input.Size = new System.Drawing.Size(365, 353);
            this.box_Input.TabIndex = 0;
            this.box_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input.Location = new System.Drawing.Point(8, 9);
            this.lbl_Input.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(51, 24);
            this.lbl_Input.TabIndex = 1;
            this.lbl_Input.Text = "Input";
            // 
            // box_List
            // 
            this.box_List.AcceptsReturn = true;
            this.box_List.BackColor = System.Drawing.Color.LightSteelBlue;
            this.box_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_List.Location = new System.Drawing.Point(595, 39);
            this.box_List.Multiline = true;
            this.box_List.Name = "box_List";
            this.box_List.Size = new System.Drawing.Size(170, 400);
            this.box_List.TabIndex = 3;
            this.box_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // lbl_List
            // 
            this.lbl_List.AutoSize = true;
            this.lbl_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List.Location = new System.Drawing.Point(591, 9);
            this.lbl_List.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_List.Name = "lbl_List";
            this.lbl_List.Size = new System.Drawing.Size(37, 24);
            this.lbl_List.TabIndex = 5;
            this.lbl_List.Text = "List";
            // 
            // btn_Stats
            // 
            this.btn_Stats.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stats.Location = new System.Drawing.Point(118, 398);
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.Size = new System.Drawing.Size(100, 40);
            this.btn_Stats.TabIndex = 6;
            this.btn_Stats.Text = "&Stats";
            this.btn_Stats.UseVisualStyleBackColor = false;
            this.btn_Stats.Click += new System.EventHandler(this.btn_Stats_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(383, 399);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 40);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(489, 399);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 40);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // grpBox_WordLists
            // 
            this.grpBox_WordLists.Controls.Add(this.rdo_WordPairs);
            this.grpBox_WordLists.Controls.Add(this.rdo_Words);
            this.grpBox_WordLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_WordLists.Location = new System.Drawing.Point(383, 190);
            this.grpBox_WordLists.Name = "grpBox_WordLists";
            this.grpBox_WordLists.Size = new System.Drawing.Size(206, 98);
            this.grpBox_WordLists.TabIndex = 9;
            this.grpBox_WordLists.TabStop = false;
            this.grpBox_WordLists.Text = "Word List";
            // 
            // rdo_WordPairs
            // 
            this.rdo_WordPairs.AutoSize = true;
            this.rdo_WordPairs.Location = new System.Drawing.Point(6, 62);
            this.rdo_WordPairs.Name = "rdo_WordPairs";
            this.rdo_WordPairs.Size = new System.Drawing.Size(120, 28);
            this.rdo_WordPairs.TabIndex = 11;
            this.rdo_WordPairs.TabStop = true;
            this.rdo_WordPairs.Text = "Word Pairs";
            this.rdo_WordPairs.UseVisualStyleBackColor = true;
            this.rdo_WordPairs.CheckedChanged += new System.EventHandler(this.rdo_WordPairs_CheckedChanged);
            // 
            // rdo_Words
            // 
            this.rdo_Words.AutoSize = true;
            this.rdo_Words.Checked = true;
            this.rdo_Words.Location = new System.Drawing.Point(6, 28);
            this.rdo_Words.Name = "rdo_Words";
            this.rdo_Words.Size = new System.Drawing.Size(83, 28);
            this.rdo_Words.TabIndex = 10;
            this.rdo_Words.TabStop = true;
            this.rdo_Words.Text = "Words";
            this.rdo_Words.UseVisualStyleBackColor = true;
            this.rdo_Words.CheckedChanged += new System.EventHandler(this.rdo_Words_CheckedChanged);
            // 
            // chkBox_Unique
            // 
            this.chkBox_Unique.AutoSize = true;
            this.chkBox_Unique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_Unique.Location = new System.Drawing.Point(6, 28);
            this.chkBox_Unique.Name = "chkBox_Unique";
            this.chkBox_Unique.Size = new System.Drawing.Size(90, 28);
            this.chkBox_Unique.TabIndex = 10;
            this.chkBox_Unique.Text = "Unique";
            this.chkBox_Unique.UseVisualStyleBackColor = true;
            this.chkBox_Unique.CheckedChanged += new System.EventHandler(this.chkBox_Unique_CheckedChanged);
            // 
            // grpBox_Unique
            // 
            this.grpBox_Unique.Controls.Add(this.chkBox_Frequency);
            this.grpBox_Unique.Controls.Add(this.chkBox_Unique);
            this.grpBox_Unique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Unique.Location = new System.Drawing.Point(383, 294);
            this.grpBox_Unique.Name = "grpBox_Unique";
            this.grpBox_Unique.Size = new System.Drawing.Size(205, 98);
            this.grpBox_Unique.TabIndex = 12;
            this.grpBox_Unique.TabStop = false;
            this.grpBox_Unique.Text = "Word List";
            // 
            // chkBox_Frequency
            // 
            this.chkBox_Frequency.AutoSize = true;
            this.chkBox_Frequency.Enabled = false;
            this.chkBox_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_Frequency.Location = new System.Drawing.Point(6, 62);
            this.chkBox_Frequency.Name = "chkBox_Frequency";
            this.chkBox_Frequency.Size = new System.Drawing.Size(121, 28);
            this.chkBox_Frequency.TabIndex = 11;
            this.chkBox_Frequency.Text = "Frequency";
            this.chkBox_Frequency.UseVisualStyleBackColor = true;
            this.chkBox_Frequency.Visible = false;
            this.chkBox_Frequency.CheckedChanged += new System.EventHandler(this.chkBox_Frequency_CheckedChanged);
            // 
            // btn_ShowList
            // 
            this.btn_ShowList.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowList.Location = new System.Drawing.Point(12, 399);
            this.btn_ShowList.Name = "btn_ShowList";
            this.btn_ShowList.Size = new System.Drawing.Size(100, 40);
            this.btn_ShowList.TabIndex = 13;
            this.btn_ShowList.Text = "&List";
            this.btn_ShowList.UseVisualStyleBackColor = false;
            this.btn_ShowList.Click += new System.EventHandler(this.btn_ShowList_Click);
            // 
            // lbl_Stats
            // 
            this.lbl_Stats.AutoSize = true;
            this.lbl_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stats.Location = new System.Drawing.Point(379, 9);
            this.lbl_Stats.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Stats.Name = "lbl_Stats";
            this.lbl_Stats.Size = new System.Drawing.Size(49, 24);
            this.lbl_Stats.TabIndex = 4;
            this.lbl_Stats.Text = "Stats";
            // 
            // box_Stats
            // 
            this.box_Stats.BackColor = System.Drawing.Color.LightSteelBlue;
            this.box_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Stats.Location = new System.Drawing.Point(383, 39);
            this.box_Stats.Multiline = true;
            this.box_Stats.Name = "box_Stats";
            this.box_Stats.Size = new System.Drawing.Size(206, 145);
            this.box_Stats.TabIndex = 2;
            // 
            // StringStats
            // 
            this.AcceptButton = this.btn_Stats;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btn_ShowList);
            this.Controls.Add(this.grpBox_Unique);
            this.Controls.Add(this.grpBox_WordLists);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.lbl_List);
            this.Controls.Add(this.lbl_Stats);
            this.Controls.Add(this.box_List);
            this.Controls.Add(this.box_Stats);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.box_Input);
            this.Name = "StringStats";
            this.Text = "String Stats";
            this.grpBox_WordLists.ResumeLayout(false);
            this.grpBox_WordLists.PerformLayout();
            this.grpBox_Unique.ResumeLayout(false);
            this.grpBox_Unique.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_Input;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.TextBox box_List;
        private System.Windows.Forms.Label lbl_List;
        private System.Windows.Forms.Button btn_Stats;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox grpBox_WordLists;
        private System.Windows.Forms.RadioButton rdo_WordPairs;
        private System.Windows.Forms.RadioButton rdo_Words;
        private System.Windows.Forms.CheckBox chkBox_Unique;
        private System.Windows.Forms.GroupBox grpBox_Unique;
        private System.Windows.Forms.CheckBox chkBox_Frequency;
        private System.Windows.Forms.Button btn_ShowList;
        private System.Windows.Forms.Label lbl_Stats;
        private System.Windows.Forms.TextBox box_Stats;
    }
}

