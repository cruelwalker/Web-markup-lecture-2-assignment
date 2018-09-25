namespace Assignment_9._0
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.rkFootball = new System.Windows.Forms.RadioButton();
            this.rkHandball = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Membership duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fee to be paid";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(37, 183);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(231, 40);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "&Calculate Fee";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(167, 119);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(101, 20);
            this.txtAge.TabIndex = 5;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(167, 145);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(101, 20);
            this.txtMember.TabIndex = 6;
            this.txtMember.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rkFootball
            // 
            this.rkFootball.AutoSize = true;
            this.rkFootball.Location = new System.Drawing.Point(167, 49);
            this.rkFootball.Name = "rkFootball";
            this.rkFootball.Size = new System.Drawing.Size(62, 17);
            this.rkFootball.TabIndex = 7;
            this.rkFootball.TabStop = true;
            this.rkFootball.Text = "Football";
            this.rkFootball.UseVisualStyleBackColor = true;
            this.rkFootball.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rkHandball
            // 
            this.rkHandball.AutoSize = true;
            this.rkHandball.Location = new System.Drawing.Point(167, 72);
            this.rkHandball.Name = "rkHandball";
            this.rkHandball.Size = new System.Drawing.Size(68, 17);
            this.rkHandball.TabIndex = 8;
            this.rkHandball.TabStop = true;
            this.rkHandball.Text = "HandBall";
            this.rkHandball.UseVisualStyleBackColor = true;
            this.rkHandball.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(164, 247);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "label5";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.rkHandball);
            this.Controls.Add(this.rkFootball);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.RadioButton rkFootball;
        private System.Windows.Forms.RadioButton rkHandball;
        private System.Windows.Forms.Label lblPrice;
    }
}

