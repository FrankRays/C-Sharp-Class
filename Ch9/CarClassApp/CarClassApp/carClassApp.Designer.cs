namespace CarClassApp
{
    partial class carClassApp
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
            this.btAccelrate = new System.Windows.Forms.Button();
            this.btBrake = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAccelrate
            // 
            this.btAccelrate.BackColor = System.Drawing.Color.Lime;
            this.btAccelrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccelrate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAccelrate.Location = new System.Drawing.Point(40, 229);
            this.btAccelrate.Name = "btAccelrate";
            this.btAccelrate.Size = new System.Drawing.Size(130, 60);
            this.btAccelrate.TabIndex = 0;
            this.btAccelrate.Text = "Accelrate";
            this.btAccelrate.UseVisualStyleBackColor = false;
            this.btAccelrate.Click += new System.EventHandler(this.btAccelrate_Click);
            // 
            // btBrake
            // 
            this.btBrake.BackColor = System.Drawing.Color.Red;
            this.btBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrake.Location = new System.Drawing.Point(301, 229);
            this.btBrake.Name = "btBrake";
            this.btBrake.Size = new System.Drawing.Size(125, 60);
            this.btBrake.TabIndex = 1;
            this.btBrake.Text = "Brake";
            this.btBrake.UseVisualStyleBackColor = false;
            this.btBrake.Click += new System.EventHandler(this.btBrake_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSpeed.Location = new System.Drawing.Point(55, 161);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(212, 55);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "0.00mph";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(40, 40);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(103, 37);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(42, 107);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(94, 37);
            this.lblyear.TabIndex = 4;
            this.lblyear.Text = "Year:";
            // 
            // carClassApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(491, 340);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btBrake);
            this.Controls.Add(this.btAccelrate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "carClassApp";
            this.Text = "CarClassApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAccelrate;
        private System.Windows.Forms.Button btBrake;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblyear;
    }
}

