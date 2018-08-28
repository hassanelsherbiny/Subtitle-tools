namespace Subtitles_Tools
{
    partial class ManualShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualShift));
            this.BtnShift = new System.Windows.Forms.Button();
            this.hr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.NumericUpDown();
            this.ms = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ms)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShift
            // 
            this.BtnShift.Location = new System.Drawing.Point(6, 88);
            this.BtnShift.Name = "BtnShift";
            this.BtnShift.Size = new System.Drawing.Size(270, 23);
            this.BtnShift.TabIndex = 0;
            this.BtnShift.Text = "Shift";
            this.BtnShift.UseVisualStyleBackColor = true;
            this.BtnShift.Click += new System.EventHandler(this.BtnShift_Click);
            // 
            // hr
            // 
            this.hr.Location = new System.Drawing.Point(28, 35);
            this.hr.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.hr.Minimum = new decimal(new int[] {
            59,
            0,
            0,
            -2147483648});
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(35, 20);
            this.hr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // mnt
            // 
            this.mnt.Location = new System.Drawing.Point(86, 35);
            this.mnt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.mnt.Minimum = new decimal(new int[] {
            59,
            0,
            0,
            -2147483648});
            this.mnt.Name = "mnt";
            this.mnt.Size = new System.Drawing.Size(35, 20);
            this.mnt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(144, 35);
            this.sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.sec.Minimum = new decimal(new int[] {
            59,
            0,
            0,
            -2147483648});
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(35, 20);
            this.sec.TabIndex = 5;
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(202, 35);
            this.ms.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ms.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(48, 20);
            this.ms.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnShift);
            this.groupBox1.Controls.Add(this.hr);
            this.groupBox1.Controls.Add(this.ms);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mnt);
            this.groupBox1.Controls.Add(this.sec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "MS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "H";
            // 
            // ManualShift
            // 
            this.AcceptButton = this.BtnShift;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 138);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Shift";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShift;
        private System.Windows.Forms.NumericUpDown hr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sec;
        private System.Windows.Forms.NumericUpDown ms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

