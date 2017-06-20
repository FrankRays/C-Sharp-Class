namespace RandomNumberGuessingGame
{
    partial class randomNumberGuessingGameForm
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
            this.btGuess = new System.Windows.Forms.Button();
            this.tbGuessInput = new System.Windows.Forms.TextBox();
            this.lbGuessState = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGuess
            // 
            this.btGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuess.Location = new System.Drawing.Point(110, 114);
            this.btGuess.Name = "btGuess";
            this.btGuess.Size = new System.Drawing.Size(75, 28);
            this.btGuess.TabIndex = 2;
            this.btGuess.Text = "Guess";
            this.btGuess.UseVisualStyleBackColor = true;
            this.btGuess.Click += new System.EventHandler(this.btGuess_Click);
            // 
            // tbGuessInput
            // 
            this.tbGuessInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuessInput.Location = new System.Drawing.Point(83, 82);
            this.tbGuessInput.Name = "tbGuessInput";
            this.tbGuessInput.Size = new System.Drawing.Size(129, 26);
            this.tbGuessInput.TabIndex = 1;
            // 
            // lbGuessState
            // 
            this.lbGuessState.AutoSize = true;
            this.lbGuessState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuessState.ForeColor = System.Drawing.Color.Green;
            this.lbGuessState.Location = new System.Drawing.Point(12, 9);
            this.lbGuessState.Name = "lbGuessState";
            this.lbGuessState.Size = new System.Drawing.Size(285, 29);
            this.lbGuessState.TabIndex = 3;
            this.lbGuessState.Text = "Guess a number, 1 to 100";
            this.lbGuessState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(38, 66);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(229, 13);
            this.lbError.TabIndex = 4;
            this.lbError.Text = "Invalid number, use a number between 1 - 100.";
            this.lbError.Visible = false;
            // 
            // randomNumberGuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(298, 154);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbGuessState);
            this.Controls.Add(this.tbGuessInput);
            this.Controls.Add(this.btGuess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "randomNumberGuessingGameForm";
            this.Text = "Random Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuess;
        private System.Windows.Forms.TextBox tbGuessInput;
        private System.Windows.Forms.Label lbGuessState;
        private System.Windows.Forms.Label lbError;
    }
}

