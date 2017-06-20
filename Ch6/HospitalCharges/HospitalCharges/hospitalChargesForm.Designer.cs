namespace HospitalCharges
{
    partial class hospitalChargesForm
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
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMedication = new System.Windows.Forms.Label();
            this.lblSurgical = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblPhysicalRehab = new System.Windows.Forms.Label();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbMedication = new System.Windows.Forms.TextBox();
            this.tbSurgical = new System.Windows.Forms.TextBox();
            this.tbLab = new System.Windows.Forms.TextBox();
            this.tbPhysical = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbMiscCharge = new System.Windows.Forms.TextBox();
            this.tbStayCharge = new System.Windows.Forms.TextBox();
            this.lblCalcTotalCharges = new System.Windows.Forms.Label();
            this.lblMiscCharges = new System.Windows.Forms.Label();
            this.lblCalcStayCharges = new System.Windows.Forms.Label();
            this.lblErrorDays = new System.Windows.Forms.Label();
            this.lblErrorMedication = new System.Windows.Forms.Label();
            this.lblErrorSurgical = new System.Windows.Forms.Label();
            this.lblErrorLab = new System.Windows.Forms.Label();
            this.lblErrorPhysical = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(97, 30);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days:";
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Location = new System.Drawing.Point(32, 60);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(99, 13);
            this.lblMedication.TabIndex = 1;
            this.lblMedication.Text = "Medication Charge:";
            // 
            // lblSurgical
            // 
            this.lblSurgical.AutoSize = true;
            this.lblSurgical.Location = new System.Drawing.Point(47, 87);
            this.lblSurgical.Name = "lblSurgical";
            this.lblSurgical.Size = new System.Drawing.Size(85, 13);
            this.lblSurgical.TabIndex = 2;
            this.lblSurgical.Text = "Surgical Charge:";
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(85, 117);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(46, 13);
            this.lblLab.TabIndex = 3;
            this.lblLab.Text = "Lab fee:";
            // 
            // lblPhysicalRehab
            // 
            this.lblPhysicalRehab.AutoSize = true;
            this.lblPhysicalRehab.Location = new System.Drawing.Point(15, 145);
            this.lblPhysicalRehab.Name = "lblPhysicalRehab";
            this.lblPhysicalRehab.Size = new System.Drawing.Size(116, 13);
            this.lblPhysicalRehab.TabIndex = 4;
            this.lblPhysicalRehab.Text = "Physical Rehabilitation:";
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(138, 30);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(100, 20);
            this.tbDays.TabIndex = 0;
            this.tbDays.Text = "0";
            this.tbDays.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbDays.Enter += new System.EventHandler(this.tbDays_Enter);
            // 
            // tbMedication
            // 
            this.tbMedication.Location = new System.Drawing.Point(138, 60);
            this.tbMedication.Name = "tbMedication";
            this.tbMedication.Size = new System.Drawing.Size(100, 20);
            this.tbMedication.TabIndex = 1;
            this.tbMedication.Text = "0";
            this.tbMedication.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbMedication.Enter += new System.EventHandler(this.tbMedication_Enter);
            // 
            // tbSurgical
            // 
            this.tbSurgical.Location = new System.Drawing.Point(138, 87);
            this.tbSurgical.Name = "tbSurgical";
            this.tbSurgical.Size = new System.Drawing.Size(100, 20);
            this.tbSurgical.TabIndex = 2;
            this.tbSurgical.Text = "0";
            this.tbSurgical.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbSurgical.Enter += new System.EventHandler(this.tbSurgical_Enter);
            // 
            // tbLab
            // 
            this.tbLab.Location = new System.Drawing.Point(138, 117);
            this.tbLab.Name = "tbLab";
            this.tbLab.Size = new System.Drawing.Size(100, 20);
            this.tbLab.TabIndex = 3;
            this.tbLab.Text = "0";
            this.tbLab.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbLab.Enter += new System.EventHandler(this.tbLab_Enter);
            // 
            // tbPhysical
            // 
            this.tbPhysical.Location = new System.Drawing.Point(138, 144);
            this.tbPhysical.Name = "tbPhysical";
            this.tbPhysical.Size = new System.Drawing.Size(100, 20);
            this.tbPhysical.TabIndex = 4;
            this.tbPhysical.Text = "0";
            this.tbPhysical.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbPhysical.Enter += new System.EventHandler(this.tbPhysical_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDate);
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.tbMiscCharge);
            this.groupBox1.Controls.Add(this.tbStayCharge);
            this.groupBox1.Controls.Add(this.lblCalcTotalCharges);
            this.groupBox1.Controls.Add(this.lblMiscCharges);
            this.groupBox1.Controls.Add(this.lblCalcStayCharges);
            this.groupBox1.Location = new System.Drawing.Point(18, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 151);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(120, 121);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 9;
            // 
            // tbMiscCharge
            // 
            this.tbMiscCharge.Location = new System.Drawing.Point(120, 95);
            this.tbMiscCharge.Name = "tbMiscCharge";
            this.tbMiscCharge.ReadOnly = true;
            this.tbMiscCharge.Size = new System.Drawing.Size(100, 20);
            this.tbMiscCharge.TabIndex = 8;
            // 
            // tbStayCharge
            // 
            this.tbStayCharge.Location = new System.Drawing.Point(120, 69);
            this.tbStayCharge.Name = "tbStayCharge";
            this.tbStayCharge.ReadOnly = true;
            this.tbStayCharge.Size = new System.Drawing.Size(100, 20);
            this.tbStayCharge.TabIndex = 7;
            // 
            // lblCalcTotalCharges
            // 
            this.lblCalcTotalCharges.AutoSize = true;
            this.lblCalcTotalCharges.Location = new System.Drawing.Point(75, 121);
            this.lblCalcTotalCharges.Name = "lblCalcTotalCharges";
            this.lblCalcTotalCharges.Size = new System.Drawing.Size(34, 13);
            this.lblCalcTotalCharges.TabIndex = 2;
            this.lblCalcTotalCharges.Text = "Total:";
            // 
            // lblMiscCharges
            // 
            this.lblMiscCharges.AutoSize = true;
            this.lblMiscCharges.Location = new System.Drawing.Point(12, 95);
            this.lblMiscCharges.Name = "lblMiscCharges";
            this.lblMiscCharges.Size = new System.Drawing.Size(101, 13);
            this.lblMiscCharges.TabIndex = 1;
            this.lblMiscCharges.Text = "Total Misc Charges:";
            // 
            // lblCalcStayCharges
            // 
            this.lblCalcStayCharges.AutoSize = true;
            this.lblCalcStayCharges.Location = new System.Drawing.Point(14, 69);
            this.lblCalcStayCharges.Name = "lblCalcStayCharges";
            this.lblCalcStayCharges.Size = new System.Drawing.Size(95, 13);
            this.lblCalcStayCharges.TabIndex = 0;
            this.lblCalcStayCharges.Text = "Total Stay Charge:";
            // 
            // lblErrorDays
            // 
            this.lblErrorDays.AutoSize = true;
            this.lblErrorDays.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDays.Location = new System.Drawing.Point(245, 34);
            this.lblErrorDays.Name = "lblErrorDays";
            this.lblErrorDays.Size = new System.Drawing.Size(11, 13);
            this.lblErrorDays.TabIndex = 11;
            this.lblErrorDays.Text = "*";
            this.lblErrorDays.Visible = false;
            // 
            // lblErrorMedication
            // 
            this.lblErrorMedication.AutoSize = true;
            this.lblErrorMedication.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMedication.Location = new System.Drawing.Point(245, 63);
            this.lblErrorMedication.Name = "lblErrorMedication";
            this.lblErrorMedication.Size = new System.Drawing.Size(11, 13);
            this.lblErrorMedication.TabIndex = 12;
            this.lblErrorMedication.Text = "*";
            this.lblErrorMedication.Visible = false;
            // 
            // lblErrorSurgical
            // 
            this.lblErrorSurgical.AutoSize = true;
            this.lblErrorSurgical.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSurgical.Location = new System.Drawing.Point(245, 90);
            this.lblErrorSurgical.Name = "lblErrorSurgical";
            this.lblErrorSurgical.Size = new System.Drawing.Size(11, 13);
            this.lblErrorSurgical.TabIndex = 13;
            this.lblErrorSurgical.Text = "*";
            this.lblErrorSurgical.Visible = false;
            // 
            // lblErrorLab
            // 
            this.lblErrorLab.AutoSize = true;
            this.lblErrorLab.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLab.Location = new System.Drawing.Point(245, 120);
            this.lblErrorLab.Name = "lblErrorLab";
            this.lblErrorLab.Size = new System.Drawing.Size(11, 13);
            this.lblErrorLab.TabIndex = 14;
            this.lblErrorLab.Text = "*";
            this.lblErrorLab.Visible = false;
            // 
            // lblErrorPhysical
            // 
            this.lblErrorPhysical.AutoSize = true;
            this.lblErrorPhysical.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhysical.Location = new System.Drawing.Point(245, 145);
            this.lblErrorPhysical.Name = "lblErrorPhysical";
            this.lblErrorPhysical.Size = new System.Drawing.Size(11, 13);
            this.lblErrorPhysical.TabIndex = 15;
            this.lblErrorPhysical.Text = "*";
            this.lblErrorPhysical.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(18, 169);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(105, 13);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "*Invalid data entered";
            this.lblError.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveAsToolStripMenuItem.Text = "SaveAs";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(75, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(75, 47);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "charges.txt";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(120, 40);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 6;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(120, 13);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 5;
            // 
            // hospitalChargesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 351);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblErrorPhysical);
            this.Controls.Add(this.lblErrorLab);
            this.Controls.Add(this.lblErrorSurgical);
            this.Controls.Add(this.lblErrorMedication);
            this.Controls.Add(this.lblErrorDays);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPhysical);
            this.Controls.Add(this.tbLab);
            this.Controls.Add(this.tbSurgical);
            this.Controls.Add(this.tbMedication);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.lblPhysicalRehab);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblSurgical);
            this.Controls.Add(this.lblMedication);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "hospitalChargesForm";
            this.Text = "Hospital Charges";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblSurgical;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblPhysicalRehab;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.TextBox tbMedication;
        private System.Windows.Forms.TextBox tbSurgical;
        private System.Windows.Forms.TextBox tbLab;
        private System.Windows.Forms.TextBox tbPhysical;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbMiscCharge;
        private System.Windows.Forms.TextBox tbStayCharge;
        private System.Windows.Forms.Label lblCalcTotalCharges;
        private System.Windows.Forms.Label lblMiscCharges;
        private System.Windows.Forms.Label lblCalcStayCharges;
        private System.Windows.Forms.Label lblErrorDays;
        private System.Windows.Forms.Label lblErrorMedication;
        private System.Windows.Forms.Label lblErrorSurgical;
        private System.Windows.Forms.Label lblErrorLab;
        private System.Windows.Forms.Label lblErrorPhysical;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

