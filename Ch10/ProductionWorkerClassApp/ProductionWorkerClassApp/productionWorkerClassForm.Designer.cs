namespace ProductionWorkerClassApp
{
    partial class productionWorkerClassApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudShift = new System.Windows.Forms.NumericUpDown();
            this.lblPayRateError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblShiftError = new System.Windows.Forms.Label();
            this.btCreate = new System.Windows.Forms.Button();
            this.lblNumberError = new System.Windows.Forms.Label();
            this.tbEmployeePayRate = new System.Windows.Forms.TextBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.tbEmployeeNumber = new System.Windows.Forms.TextBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeNameClass = new System.Windows.Forms.Label();
            this.lblEmployeeNumberClass = new System.Windows.Forms.Label();
            this.lblShiftClass = new System.Windows.Forms.Label();
            this.lblPayRateClass = new System.Windows.Forms.Label();
            this.tbEmployeeNameClass = new System.Windows.Forms.TextBox();
            this.tbEmployeeNumberClass = new System.Windows.Forms.TextBox();
            this.tbShiftClass = new System.Windows.Forms.TextBox();
            this.tbPayRateClass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShift)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudShift);
            this.groupBox1.Controls.Add(this.lblPayRateError);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.lblShiftError);
            this.groupBox1.Controls.Add(this.btCreate);
            this.groupBox1.Controls.Add(this.lblNumberError);
            this.groupBox1.Controls.Add(this.tbEmployeePayRate);
            this.groupBox1.Controls.Add(this.lblNameError);
            this.groupBox1.Controls.Add(this.tbEmployeeNumber);
            this.groupBox1.Controls.Add(this.tbEmployeeName);
            this.groupBox1.Controls.Add(this.lblPayRate);
            this.groupBox1.Controls.Add(this.lblShift);
            this.groupBox1.Controls.Add(this.lblEmployeeNumber);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nudShift
            // 
            this.nudShift.Location = new System.Drawing.Point(209, 100);
            this.nudShift.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShift.Name = "nudShift";
            this.nudShift.ReadOnly = true;
            this.nudShift.Size = new System.Drawing.Size(146, 26);
            this.nudShift.TabIndex = 3;
            this.nudShift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShift.ValueChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // lblPayRateError
            // 
            this.lblPayRateError.AutoSize = true;
            this.lblPayRateError.ForeColor = System.Drawing.Color.Red;
            this.lblPayRateError.Location = new System.Drawing.Point(360, 149);
            this.lblPayRateError.Name = "lblPayRateError";
            this.lblPayRateError.Size = new System.Drawing.Size(15, 20);
            this.lblPayRateError.TabIndex = 8;
            this.lblPayRateError.Text = "*";
            this.lblPayRateError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(10, 186);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(101, 20);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "*Invalid Input";
            this.lblError.Visible = false;
            // 
            // lblShiftError
            // 
            this.lblShiftError.AutoSize = true;
            this.lblShiftError.ForeColor = System.Drawing.Color.Red;
            this.lblShiftError.Location = new System.Drawing.Point(360, 102);
            this.lblShiftError.Name = "lblShiftError";
            this.lblShiftError.Size = new System.Drawing.Size(15, 20);
            this.lblShiftError.TabIndex = 7;
            this.lblShiftError.Text = "*";
            this.lblShiftError.Visible = false;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(258, 201);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(96, 31);
            this.btCreate.TabIndex = 5;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lblNumberError
            // 
            this.lblNumberError.AutoSize = true;
            this.lblNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblNumberError.Location = new System.Drawing.Point(360, 58);
            this.lblNumberError.Name = "lblNumberError";
            this.lblNumberError.Size = new System.Drawing.Size(15, 20);
            this.lblNumberError.TabIndex = 6;
            this.lblNumberError.Text = "*";
            this.lblNumberError.Visible = false;
            // 
            // tbEmployeePayRate
            // 
            this.tbEmployeePayRate.Location = new System.Drawing.Point(208, 149);
            this.tbEmployeePayRate.Name = "tbEmployeePayRate";
            this.tbEmployeePayRate.Size = new System.Drawing.Size(146, 26);
            this.tbEmployeePayRate.TabIndex = 4;
            this.tbEmployeePayRate.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(360, 19);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(15, 20);
            this.lblNameError.TabIndex = 5;
            this.lblNameError.Text = "*";
            this.lblNameError.Visible = false;
            // 
            // tbEmployeeNumber
            // 
            this.tbEmployeeNumber.Location = new System.Drawing.Point(208, 58);
            this.tbEmployeeNumber.Name = "tbEmployeeNumber";
            this.tbEmployeeNumber.Size = new System.Drawing.Size(146, 26);
            this.tbEmployeeNumber.TabIndex = 2;
            this.tbEmployeeNumber.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(208, 19);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(146, 26);
            this.tbEmployeeName.TabIndex = 1;
            this.tbEmployeeName.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(15, 152);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(70, 20);
            this.lblPayRate.TabIndex = 3;
            this.lblPayRate.Text = "PayRate";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(15, 105);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(160, 20);
            this.lblShift.TabIndex = 2;
            this.lblShift.Text = "Shift(shift 1 or shift 2)";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(15, 61);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(135, 20);
            this.lblEmployeeNumber.TabIndex = 1;
            this.lblEmployeeNumber.Text = "EmployeeNumber";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(15, 22);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(121, 20);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // lblEmployeeNameClass
            // 
            this.lblEmployeeNameClass.AutoSize = true;
            this.lblEmployeeNameClass.Location = new System.Drawing.Point(27, 276);
            this.lblEmployeeNameClass.Name = "lblEmployeeNameClass";
            this.lblEmployeeNameClass.Size = new System.Drawing.Size(121, 20);
            this.lblEmployeeNameClass.TabIndex = 1;
            this.lblEmployeeNameClass.Text = "EmployeeName";
            // 
            // lblEmployeeNumberClass
            // 
            this.lblEmployeeNumberClass.AutoSize = true;
            this.lblEmployeeNumberClass.Location = new System.Drawing.Point(27, 314);
            this.lblEmployeeNumberClass.Name = "lblEmployeeNumberClass";
            this.lblEmployeeNumberClass.Size = new System.Drawing.Size(135, 20);
            this.lblEmployeeNumberClass.TabIndex = 2;
            this.lblEmployeeNumberClass.Text = "EmployeeNumber";
            // 
            // lblShiftClass
            // 
            this.lblShiftClass.AutoSize = true;
            this.lblShiftClass.Location = new System.Drawing.Point(27, 352);
            this.lblShiftClass.Name = "lblShiftClass";
            this.lblShiftClass.Size = new System.Drawing.Size(42, 20);
            this.lblShiftClass.TabIndex = 3;
            this.lblShiftClass.Text = "Shift";
            // 
            // lblPayRateClass
            // 
            this.lblPayRateClass.AutoSize = true;
            this.lblPayRateClass.Location = new System.Drawing.Point(27, 390);
            this.lblPayRateClass.Name = "lblPayRateClass";
            this.lblPayRateClass.Size = new System.Drawing.Size(70, 20);
            this.lblPayRateClass.TabIndex = 4;
            this.lblPayRateClass.Text = "PayRate";
            // 
            // tbEmployeeNameClass
            // 
            this.tbEmployeeNameClass.Location = new System.Drawing.Point(220, 273);
            this.tbEmployeeNameClass.Name = "tbEmployeeNameClass";
            this.tbEmployeeNameClass.ReadOnly = true;
            this.tbEmployeeNameClass.Size = new System.Drawing.Size(146, 26);
            this.tbEmployeeNameClass.TabIndex = 6;
            // 
            // tbEmployeeNumberClass
            // 
            this.tbEmployeeNumberClass.Location = new System.Drawing.Point(220, 311);
            this.tbEmployeeNumberClass.Name = "tbEmployeeNumberClass";
            this.tbEmployeeNumberClass.ReadOnly = true;
            this.tbEmployeeNumberClass.Size = new System.Drawing.Size(146, 26);
            this.tbEmployeeNumberClass.TabIndex = 7;
            // 
            // tbShiftClass
            // 
            this.tbShiftClass.Location = new System.Drawing.Point(220, 349);
            this.tbShiftClass.Name = "tbShiftClass";
            this.tbShiftClass.ReadOnly = true;
            this.tbShiftClass.Size = new System.Drawing.Size(146, 26);
            this.tbShiftClass.TabIndex = 8;
            // 
            // tbPayRateClass
            // 
            this.tbPayRateClass.Location = new System.Drawing.Point(220, 387);
            this.tbPayRateClass.Name = "tbPayRateClass";
            this.tbPayRateClass.ReadOnly = true;
            this.tbPayRateClass.Size = new System.Drawing.Size(146, 26);
            this.tbPayRateClass.TabIndex = 9;
            // 
            // productionWorkerClassApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(414, 444);
            this.Controls.Add(this.tbPayRateClass);
            this.Controls.Add(this.tbShiftClass);
            this.Controls.Add(this.tbEmployeeNumberClass);
            this.Controls.Add(this.tbEmployeeNameClass);
            this.Controls.Add(this.lblPayRateClass);
            this.Controls.Add(this.lblShiftClass);
            this.Controls.Add(this.lblEmployeeNumberClass);
            this.Controls.Add(this.lblEmployeeNameClass);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "productionWorkerClassApp";
            this.Text = "ProductionWorker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeNameClass;
        private System.Windows.Forms.Label lblEmployeeNumberClass;
        private System.Windows.Forms.Label lblShiftClass;
        private System.Windows.Forms.Label lblPayRateClass;
        private System.Windows.Forms.TextBox tbEmployeePayRate;
        private System.Windows.Forms.TextBox tbEmployeeNumber;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPayRateError;
        private System.Windows.Forms.Label lblShiftError;
        private System.Windows.Forms.Label lblNumberError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.TextBox tbEmployeeNameClass;
        private System.Windows.Forms.TextBox tbEmployeeNumberClass;
        private System.Windows.Forms.TextBox tbShiftClass;
        private System.Windows.Forms.TextBox tbPayRateClass;
        private System.Windows.Forms.NumericUpDown nudShift;
    }
}

