namespace DrinkVendingMachineSimulator
{
    partial class VendingMachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendingMachineForm));
            this.btGrapeSoda = new System.Windows.Forms.Button();
            this.btLemonLime = new System.Windows.Forms.Button();
            this.btCreamSoda = new System.Windows.Forms.Button();
            this.btRootBeer = new System.Windows.Forms.Button();
            this.btCola = new System.Windows.Forms.Button();
            this.btWater = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btVend = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbTotalSales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGrapeSoda
            // 
            this.btGrapeSoda.BackColor = System.Drawing.Color.Transparent;
            this.btGrapeSoda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGrapeSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrapeSoda.Location = new System.Drawing.Point(71, 96);
            this.btGrapeSoda.Margin = new System.Windows.Forms.Padding(2);
            this.btGrapeSoda.Name = "btGrapeSoda";
            this.btGrapeSoda.Size = new System.Drawing.Size(52, 51);
            this.btGrapeSoda.TabIndex = 2;
            this.btGrapeSoda.Tag = "";
            this.btGrapeSoda.Text = "Grape Soda";
            this.btGrapeSoda.UseVisualStyleBackColor = false;
            this.btGrapeSoda.Click += new System.EventHandler(this.bt_Click);
            // 
            // btLemonLime
            // 
            this.btLemonLime.BackColor = System.Drawing.Color.Transparent;
            this.btLemonLime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLemonLime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLemonLime.Location = new System.Drawing.Point(70, 164);
            this.btLemonLime.Margin = new System.Windows.Forms.Padding(2);
            this.btLemonLime.Name = "btLemonLime";
            this.btLemonLime.Size = new System.Drawing.Size(52, 51);
            this.btLemonLime.TabIndex = 3;
            this.btLemonLime.Text = "Lemon Lime";
            this.btLemonLime.UseVisualStyleBackColor = false;
            this.btLemonLime.Click += new System.EventHandler(this.bt_Click);
            // 
            // btCreamSoda
            // 
            this.btCreamSoda.BackColor = System.Drawing.Color.Transparent;
            this.btCreamSoda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCreamSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreamSoda.Location = new System.Drawing.Point(70, 293);
            this.btCreamSoda.Margin = new System.Windows.Forms.Padding(2);
            this.btCreamSoda.Name = "btCreamSoda";
            this.btCreamSoda.Size = new System.Drawing.Size(52, 51);
            this.btCreamSoda.TabIndex = 4;
            this.btCreamSoda.Text = "Cream Soda";
            this.btCreamSoda.UseVisualStyleBackColor = false;
            this.btCreamSoda.Click += new System.EventHandler(this.bt_Click);
            // 
            // btRootBeer
            // 
            this.btRootBeer.BackColor = System.Drawing.Color.Transparent;
            this.btRootBeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRootBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRootBeer.Location = new System.Drawing.Point(72, 227);
            this.btRootBeer.Margin = new System.Windows.Forms.Padding(2);
            this.btRootBeer.Name = "btRootBeer";
            this.btRootBeer.Size = new System.Drawing.Size(52, 51);
            this.btRootBeer.TabIndex = 5;
            this.btRootBeer.Text = "Root Beer";
            this.btRootBeer.UseVisualStyleBackColor = false;
            this.btRootBeer.Click += new System.EventHandler(this.bt_Click);
            // 
            // btCola
            // 
            this.btCola.BackColor = System.Drawing.Color.Transparent;
            this.btCola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCola.Location = new System.Drawing.Point(69, 357);
            this.btCola.Margin = new System.Windows.Forms.Padding(2);
            this.btCola.Name = "btCola";
            this.btCola.Size = new System.Drawing.Size(52, 51);
            this.btCola.TabIndex = 6;
            this.btCola.Text = "Cola";
            this.btCola.UseVisualStyleBackColor = false;
            this.btCola.Click += new System.EventHandler(this.bt_Click);
            // 
            // btWater
            // 
            this.btWater.BackColor = System.Drawing.Color.Transparent;
            this.btWater.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWater.Location = new System.Drawing.Point(70, 422);
            this.btWater.Margin = new System.Windows.Forms.Padding(2);
            this.btWater.Name = "btWater";
            this.btWater.Size = new System.Drawing.Size(52, 51);
            this.btWater.TabIndex = 7;
            this.btWater.Text = "Water";
            this.btWater.UseVisualStyleBackColor = false;
            this.btWater.Click += new System.EventHandler(this.bt_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(161, 197);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(73, 39);
            this.lbInfo.TabIndex = 8;
            // 
            // btVend
            // 
            this.btVend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btVend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVend.Location = new System.Drawing.Point(161, 307);
            this.btVend.Margin = new System.Windows.Forms.Padding(2);
            this.btVend.Name = "btVend";
            this.btVend.Size = new System.Drawing.Size(73, 21);
            this.btVend.TabIndex = 9;
            this.btVend.Text = "Vend";
            this.btVend.UseVisualStyleBackColor = false;
            this.btVend.Click += new System.EventHandler(this.bt_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Location = new System.Drawing.Point(161, 388);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 20);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.bt_Click);
            // 
            // tbTotalSales
            // 
            this.tbTotalSales.BackColor = System.Drawing.Color.Black;
            this.tbTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbTotalSales.Location = new System.Drawing.Point(251, 53);
            this.tbTotalSales.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalSales.Name = "tbTotalSales";
            this.tbTotalSales.ReadOnly = true;
            this.tbTotalSales.Size = new System.Drawing.Size(109, 20);
            this.tbTotalSales.TabIndex = 11;
            this.tbTotalSales.Text = "Total Sales: ";
            // 
            // VendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 597);
            this.Controls.Add(this.tbTotalSales);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btVend);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btWater);
            this.Controls.Add(this.btCola);
            this.Controls.Add(this.btRootBeer);
            this.Controls.Add(this.btCreamSoda);
            this.Controls.Add(this.btLemonLime);
            this.Controls.Add(this.btGrapeSoda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "VendingMachineForm";
            this.Text = "DrinkVendingMachineSimulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGrapeSoda;
        private System.Windows.Forms.Button btLemonLime;
        private System.Windows.Forms.Button btCreamSoda;
        private System.Windows.Forms.Button btRootBeer;
        private System.Windows.Forms.Button btCola;
        private System.Windows.Forms.Button btWater;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btVend;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbTotalSales;
    }
}

