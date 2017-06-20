namespace NameSearch
{
    partial class nameSearchForm
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
            this.tbInputName = new System.Windows.Forms.TextBox();
            this.lblForNameTextBox = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbGirlName = new System.Windows.Forms.RadioButton();
            this.rbBoyName = new System.Windows.Forms.RadioButton();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInputName
            // 
            this.tbInputName.Location = new System.Drawing.Point(122, 98);
            this.tbInputName.Name = "tbInputName";
            this.tbInputName.Size = new System.Drawing.Size(100, 20);
            this.tbInputName.TabIndex = 1;
            this.tbInputName.TextChanged += new System.EventHandler(this.tbInputName_TextChanged);
            this.tbInputName.Enter += new System.EventHandler(this.tbInputName_Enter);
            // 
            // lblForNameTextBox
            // 
            this.lblForNameTextBox.AutoSize = true;
            this.lblForNameTextBox.Location = new System.Drawing.Point(41, 101);
            this.lblForNameTextBox.Name = "lblForNameTextBox";
            this.lblForNameTextBox.Size = new System.Drawing.Size(75, 13);
            this.lblForNameTextBox.TabIndex = 1;
            this.lblForNameTextBox.Text = "Enter a Name:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(33, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(169, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Enter a name to find if it is popular.";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbGirlName);
            this.gbGender.Controls.Add(this.rbBoyName);
            this.gbGender.Location = new System.Drawing.Point(24, 25);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(198, 46);
            this.gbGender.TabIndex = 3;
            this.gbGender.TabStop = false;
            // 
            // rbGirlName
            // 
            this.rbGirlName.AutoSize = true;
            this.rbGirlName.Location = new System.Drawing.Point(104, 19);
            this.rbGirlName.Name = "rbGirlName";
            this.rbGirlName.Size = new System.Drawing.Size(71, 17);
            this.rbGirlName.TabIndex = 0;
            this.rbGirlName.TabStop = true;
            this.rbGirlName.Text = "Girl Name";
            this.rbGirlName.UseVisualStyleBackColor = true;
            this.rbGirlName.CheckedChanged += new System.EventHandler(this.tbInputName_TextChanged);
            // 
            // rbBoyName
            // 
            this.rbBoyName.AutoSize = true;
            this.rbBoyName.Checked = true;
            this.rbBoyName.Location = new System.Drawing.Point(12, 19);
            this.rbBoyName.Name = "rbBoyName";
            this.rbBoyName.Size = new System.Drawing.Size(74, 17);
            this.rbBoyName.TabIndex = 0;
            this.rbBoyName.TabStop = true;
            this.rbBoyName.Text = "Boy Name";
            this.rbBoyName.UseVisualStyleBackColor = true;
            this.rbBoyName.CheckedChanged += new System.EventHandler(this.tbInputName_TextChanged);
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(21, 74);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(0, 13);
            this.lblSearchResults.TabIndex = 5;
            // 
            // nameSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 130);
            this.Controls.Add(this.lblSearchResults);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblForNameTextBox);
            this.Controls.Add(this.tbInputName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "nameSearchForm";
            this.Text = "Name Search";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputName;
        private System.Windows.Forms.Label lblForNameTextBox;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbGirlName;
        private System.Windows.Forms.RadioButton rbBoyName;
        private System.Windows.Forms.Label lblSearchResults;
    }
}

