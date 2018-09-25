namespace Assignment_13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNRD = new System.Windows.Forms.TextBox();
            this.txtNkms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNoLTanked = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.chRefeul = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of rental days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of kms";
            // 
            // txtNRD
            // 
            this.txtNRD.Location = new System.Drawing.Point(140, 18);
            this.txtNRD.Name = "txtNRD";
            this.txtNRD.Size = new System.Drawing.Size(100, 20);
            this.txtNRD.TabIndex = 2;
            this.txtNRD.TextChanged += new System.EventHandler(this.txtNRD_TextChanged);
            // 
            // txtNkms
            // 
            this.txtNkms.Location = new System.Drawing.Point(140, 45);
            this.txtNkms.Name = "txtNkms";
            this.txtNkms.Size = new System.Drawing.Size(100, 20);
            this.txtNkms.TabIndex = 3;
            this.txtNkms.TextChanged += new System.EventHandler(this.txtNkms_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of liters tanked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rental price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Calculate rental price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNoLTanked
            // 
            this.txtNoLTanked.Location = new System.Drawing.Point(140, 130);
            this.txtNoLTanked.Name = "txtNoLTanked";
            this.txtNoLTanked.Size = new System.Drawing.Size(100, 20);
            this.txtNoLTanked.TabIndex = 7;
            this.txtNoLTanked.TextChanged += new System.EventHandler(this.txtNoLTanked_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(137, 243);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "label5";
            this.lblPrice.Click += new System.EventHandler(this.price_Click);
            // 
            // chRefeul
            // 
            this.chRefeul.AutoSize = true;
            this.chRefeul.Location = new System.Drawing.Point(14, 89);
            this.chRefeul.Name = "chRefeul";
            this.chRefeul.Size = new System.Drawing.Size(156, 17);
            this.chRefeul.TabIndex = 9;
            this.chRefeul.Text = "Refeul on account of renter";
            this.chRefeul.UseVisualStyleBackColor = true;
            this.chRefeul.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 279);
            this.Controls.Add(this.chRefeul);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtNoLTanked);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNkms);
            this.Controls.Add(this.txtNRD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNRD;
        private System.Windows.Forms.TextBox txtNkms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNoLTanked;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox chRefeul;
    }
}

