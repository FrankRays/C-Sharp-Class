namespace FatPercentageCalculator
{
    partial class fatPercentageCalculatorForm
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
            this.lbErrorFatGrams = new System.Windows.Forms.Label();
            this.lbErrorCalories = new System.Windows.Forms.Label();
            this.cbLowFat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFatGrams = new System.Windows.Forms.TextBox();
            this.tbCalories = new System.Windows.Forms.TextBox();
            this.lbfatGrams = new System.Windows.Forms.Label();
            this.lbCalories = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.lbPercentCalories = new System.Windows.Forms.Label();
            this.lbCaloriesFat = new System.Windows.Forms.Label();
            this.lbLowFatOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbErrorFatGrams);
            this.groupBox1.Controls.Add(this.lbErrorCalories);
            this.groupBox1.Controls.Add(this.cbLowFat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbFatGrams);
            this.groupBox1.Controls.Add(this.tbCalories);
            this.groupBox1.Controls.Add(this.lbfatGrams);
            this.groupBox1.Controls.Add(this.lbCalories);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbErrorFatGrams
            // 
            this.lbErrorFatGrams.AutoSize = true;
            this.lbErrorFatGrams.ForeColor = System.Drawing.Color.Red;
            this.lbErrorFatGrams.Location = new System.Drawing.Point(6, 111);
            this.lbErrorFatGrams.Name = "lbErrorFatGrams";
            this.lbErrorFatGrams.Size = new System.Drawing.Size(262, 13);
            this.lbErrorFatGrams.TabIndex = 6;
            this.lbErrorFatGrams.Text = "\"Fat Grams needs to be a valid number grater than 0.\"";
            this.lbErrorFatGrams.Visible = false;
            // 
            // lbErrorCalories
            // 
            this.lbErrorCalories.AutoSize = true;
            this.lbErrorCalories.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCalories.Location = new System.Drawing.Point(6, 89);
            this.lbErrorCalories.Name = "lbErrorCalories";
            this.lbErrorCalories.Size = new System.Drawing.Size(251, 13);
            this.lbErrorCalories.TabIndex = 5;
            this.lbErrorCalories.Text = "\"Calories needs to be a valid number grater than 0.\"";
            this.lbErrorCalories.Visible = false;
            // 
            // cbLowFat
            // 
            this.cbLowFat.AutoSize = true;
            this.cbLowFat.Location = new System.Drawing.Point(91, 72);
            this.cbLowFat.Name = "cbLowFat";
            this.cbLowFat.Size = new System.Drawing.Size(15, 14);
            this.cbLowFat.TabIndex = 3;
            this.cbLowFat.TabStop = false;
            this.cbLowFat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find if Low Fat:";
            // 
            // tbFatGrams
            // 
            this.tbFatGrams.Location = new System.Drawing.Point(67, 39);
            this.tbFatGrams.Name = "tbFatGrams";
            this.tbFatGrams.Size = new System.Drawing.Size(100, 20);
            this.tbFatGrams.TabIndex = 2;
            // 
            // tbCalories
            // 
            this.tbCalories.Location = new System.Drawing.Point(67, 13);
            this.tbCalories.Name = "tbCalories";
            this.tbCalories.Size = new System.Drawing.Size(100, 20);
            this.tbCalories.TabIndex = 1;
            // 
            // lbfatGrams
            // 
            this.lbfatGrams.AutoSize = true;
            this.lbfatGrams.Location = new System.Drawing.Point(6, 42);
            this.lbfatGrams.Name = "lbfatGrams";
            this.lbfatGrams.Size = new System.Drawing.Size(55, 13);
            this.lbfatGrams.TabIndex = 1;
            this.lbfatGrams.Text = "Fat Grams";
            // 
            // lbCalories
            // 
            this.lbCalories.AutoSize = true;
            this.lbCalories.Location = new System.Drawing.Point(6, 16);
            this.lbCalories.Name = "lbCalories";
            this.lbCalories.Size = new System.Drawing.Size(44, 13);
            this.lbCalories.TabIndex = 0;
            this.lbCalories.Text = "Calories";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(219, 157);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.lbPercentCalories);
            this.gbOutput.Controls.Add(this.lbCaloriesFat);
            this.gbOutput.Controls.Add(this.lbLowFatOutput);
            this.gbOutput.Controls.Add(this.label3);
            this.gbOutput.Controls.Add(this.label2);
            this.gbOutput.Location = new System.Drawing.Point(14, 186);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(280, 106);
            this.gbOutput.TabIndex = 5;
            this.gbOutput.TabStop = false;
            // 
            // lbPercentCalories
            // 
            this.lbPercentCalories.AutoSize = true;
            this.lbPercentCalories.Location = new System.Drawing.Point(119, 50);
            this.lbPercentCalories.Name = "lbPercentCalories";
            this.lbPercentCalories.Size = new System.Drawing.Size(0, 13);
            this.lbPercentCalories.TabIndex = 4;
            // 
            // lbCaloriesFat
            // 
            this.lbCaloriesFat.AutoSize = true;
            this.lbCaloriesFat.Location = new System.Drawing.Point(120, 20);
            this.lbCaloriesFat.Name = "lbCaloriesFat";
            this.lbCaloriesFat.Size = new System.Drawing.Size(0, 13);
            this.lbCaloriesFat.TabIndex = 3;
            // 
            // lbLowFatOutput
            // 
            this.lbLowFatOutput.AutoSize = true;
            this.lbLowFatOutput.Location = new System.Drawing.Point(16, 76);
            this.lbLowFatOutput.Name = "lbLowFatOutput";
            this.lbLowFatOutput.Size = new System.Drawing.Size(0, 13);
            this.lbLowFatOutput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "% of Calories from fat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Calories from fat:";
            // 
            // fatPercentageCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 302);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fatPercentageCalculatorForm";
            this.Text = "Fat Percentage Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFatGrams;
        private System.Windows.Forms.TextBox tbCalories;
        private System.Windows.Forms.Label lbfatGrams;
        private System.Windows.Forms.Label lbCalories;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.CheckBox cbLowFat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Label lbLowFatOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbErrorFatGrams;
        private System.Windows.Forms.Label lbErrorCalories;
        private System.Windows.Forms.Label lbPercentCalories;
        private System.Windows.Forms.Label lbCaloriesFat;
    }
}



