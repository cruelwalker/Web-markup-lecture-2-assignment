namespace Assignment_14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHWeight = new System.Windows.Forms.Label();
            this.lblNBMI = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCmale = new System.Windows.Forms.Button();
            this.btnCfemale = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(161, 55);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(127, 20);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(161, 29);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(127, 20);
            this.txtLength.TabIndex = 2;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight (kg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length (cm)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHWeight);
            this.groupBox2.Controls.Add(this.lblNBMI);
            this.groupBox2.Controls.Add(this.lblBMI);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblHWeight
            // 
            this.lblHWeight.AutoSize = true;
            this.lblHWeight.Location = new System.Drawing.Point(158, 105);
            this.lblHWeight.Name = "lblHWeight";
            this.lblHWeight.Size = new System.Drawing.Size(35, 13);
            this.lblHWeight.TabIndex = 5;
            this.lblHWeight.Text = "label8";
            this.lblHWeight.Click += new System.EventHandler(this.lblHWeight_Click);
            // 
            // lblNBMI
            // 
            this.lblNBMI.AutoSize = true;
            this.lblNBMI.Location = new System.Drawing.Point(158, 73);
            this.lblNBMI.Name = "lblNBMI";
            this.lblNBMI.Size = new System.Drawing.Size(35, 13);
            this.lblNBMI.TabIndex = 4;
            this.lblNBMI.Text = "label7";
            this.lblNBMI.Click += new System.EventHandler(this.lblNBMI_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(158, 40);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(35, 13);
            this.lblBMI.TabIndex = 3;
            this.lblBMI.Text = "label6";
            this.lblBMI.Click += new System.EventHandler(this.lblBMI_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Healthy weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Normal BMI values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "BMI";
            // 
            // btnCmale
            // 
            this.btnCmale.Image = ((System.Drawing.Image)(resources.GetObject("btnCmale.Image")));
            this.btnCmale.Location = new System.Drawing.Point(12, 275);
            this.btnCmale.Name = "btnCmale";
            this.btnCmale.Size = new System.Drawing.Size(137, 199);
            this.btnCmale.TabIndex = 2;
            this.btnCmale.Text = "Calculate &Male";
            this.btnCmale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCmale.UseVisualStyleBackColor = true;
            this.btnCmale.Click += new System.EventHandler(this.btnCmale_Click);
            // 
            // btnCfemale
            // 
            this.btnCfemale.Image = ((System.Drawing.Image)(resources.GetObject("btnCfemale.Image")));
            this.btnCfemale.Location = new System.Drawing.Point(189, 275);
            this.btnCfemale.Name = "btnCfemale";
            this.btnCfemale.Size = new System.Drawing.Size(135, 199);
            this.btnCfemale.TabIndex = 3;
            this.btnCfemale.Text = "Calculate &Female";
            this.btnCfemale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCfemale.UseVisualStyleBackColor = true;
            this.btnCfemale.Click += new System.EventHandler(this.btnCfemale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 486);
            this.Controls.Add(this.btnCfemale);
            this.Controls.Add(this.btnCmale);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCmale;
        private System.Windows.Forms.Button btnCfemale;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHWeight;
        private System.Windows.Forms.Label lblNBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

