namespace Architecture_Viewer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.osNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.osVerBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.servicePackBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ramInstalledBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ramFreeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.is64bitBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ramUsageNo = new System.Windows.Forms.TextBox();
            this.ramUsed = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // osNameBox
            // 
            this.osNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.osNameBox.Location = new System.Drawing.Point(116, 141);
            this.osNameBox.Name = "osNameBox";
            this.osNameBox.ReadOnly = true;
            this.osNameBox.Size = new System.Drawing.Size(253, 20);
            this.osNameBox.TabIndex = 1;
            this.osNameBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(137, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello!";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Location = new System.Drawing.Point(147, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(222, 39);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "This tool will show you some information about your computer which can be helpful" +
    " in diagnosing problems.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "OS Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "OS Version";
            // 
            // osVerBox
            // 
            this.osVerBox.BackColor = System.Drawing.SystemColors.Window;
            this.osVerBox.Location = new System.Drawing.Point(116, 167);
            this.osVerBox.Name = "osVerBox";
            this.osVerBox.ReadOnly = true;
            this.osVerBox.Size = new System.Drawing.Size(253, 20);
            this.osVerBox.TabIndex = 5;
            this.osVerBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Service Pack";
            // 
            // servicePackBox
            // 
            this.servicePackBox.BackColor = System.Drawing.SystemColors.Window;
            this.servicePackBox.Location = new System.Drawing.Point(116, 193);
            this.servicePackBox.Name = "servicePackBox";
            this.servicePackBox.ReadOnly = true;
            this.servicePackBox.Size = new System.Drawing.Size(253, 20);
            this.servicePackBox.TabIndex = 7;
            this.servicePackBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Installed RAM";
            // 
            // ramInstalledBox
            // 
            this.ramInstalledBox.BackColor = System.Drawing.SystemColors.Window;
            this.ramInstalledBox.Location = new System.Drawing.Point(116, 219);
            this.ramInstalledBox.Name = "ramInstalledBox";
            this.ramInstalledBox.ReadOnly = true;
            this.ramInstalledBox.Size = new System.Drawing.Size(253, 20);
            this.ramInstalledBox.TabIndex = 9;
            this.ramInstalledBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Available RAM";
            // 
            // ramFreeBox
            // 
            this.ramFreeBox.BackColor = System.Drawing.SystemColors.Window;
            this.ramFreeBox.Location = new System.Drawing.Point(116, 245);
            this.ramFreeBox.Name = "ramFreeBox";
            this.ramFreeBox.ReadOnly = true;
            this.ramFreeBox.Size = new System.Drawing.Size(253, 20);
            this.ramFreeBox.TabIndex = 11;
            this.ramFreeBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label7.Location = new System.Drawing.Point(12, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "64bit?";
            // 
            // is64bitBox
            // 
            this.is64bitBox.BackColor = System.Drawing.SystemColors.Window;
            this.is64bitBox.Location = new System.Drawing.Point(116, 297);
            this.is64bitBox.Name = "is64bitBox";
            this.is64bitBox.ReadOnly = true;
            this.is64bitBox.Size = new System.Drawing.Size(253, 20);
            this.is64bitBox.TabIndex = 13;
            this.is64bitBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "© PhippsNET ITC 2015 - Version 1.0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label9.Location = new System.Drawing.Point(12, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "RAM Usage";
            // 
            // ramUsageNo
            // 
            this.ramUsageNo.BackColor = System.Drawing.SystemColors.Control;
            this.ramUsageNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ramUsageNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ramUsageNo.Location = new System.Drawing.Point(333, 275);
            this.ramUsageNo.Name = "ramUsageNo";
            this.ramUsageNo.ReadOnly = true;
            this.ramUsageNo.Size = new System.Drawing.Size(36, 13);
            this.ramUsageNo.TabIndex = 16;
            this.ramUsageNo.TabStop = false;
            // 
            // ramUsed
            // 
            this.ramUsed.Location = new System.Drawing.Point(116, 271);
            this.ramUsed.MarqueeAnimationSpeed = 0;
            this.ramUsed.Name = "ramUsed";
            this.ramUsed.Size = new System.Drawing.Size(211, 20);
            this.ramUsed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ramUsed.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Generate report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ramUsed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ramUsageNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.is64bitBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ramFreeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ramInstalledBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.servicePackBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.osVerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.osNameBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "System Information - PhippsNET ITC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox osNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox osVerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox servicePackBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ramInstalledBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ramFreeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox is64bitBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ramUsageNo;
        private System.Windows.Forms.ProgressBar ramUsed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

