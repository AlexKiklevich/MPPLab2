namespace MPP.Lab2
{
    partial class XmlMethodRedactor
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
            this.nameValue = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Package = new System.Windows.Forms.TextBox();
            this.packagevalue = new System.Windows.Forms.TextBox();
            this.Methodname = new System.Windows.Forms.TextBox();
            this.Paramscount = new System.Windows.Forms.TextBox();
            this.paramscountvalue = new System.Windows.Forms.TextBox();
            this.timeValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(266, 12);
            this.nameValue.MaxLength = 10;
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(92, 20);
            this.nameValue.TabIndex = 0;
            this.nameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameValue_KeyPress);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(60, 56);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(92, 20);
            this.Time.TabIndex = 1;
            // 
            // Package
            // 
            this.Package.Location = new System.Drawing.Point(60, 98);
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            this.Package.Size = new System.Drawing.Size(92, 20);
            this.Package.TabIndex = 2;
            // 
            // packagevalue
            // 
            this.packagevalue.Location = new System.Drawing.Point(266, 98);
            this.packagevalue.MaxLength = 10;
            this.packagevalue.Name = "packagevalue";
            this.packagevalue.Size = new System.Drawing.Size(92, 20);
            this.packagevalue.TabIndex = 3;
            this.packagevalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.packagevalue_KeyPress);
            // 
            // Methodname
            // 
            this.Methodname.Location = new System.Drawing.Point(60, 12);
            this.Methodname.Name = "Methodname";
            this.Methodname.ReadOnly = true;
            this.Methodname.Size = new System.Drawing.Size(92, 20);
            this.Methodname.TabIndex = 4;
            // 
            // Paramscount
            // 
            this.Paramscount.Location = new System.Drawing.Point(60, 138);
            this.Paramscount.Name = "Paramscount";
            this.Paramscount.ReadOnly = true;
            this.Paramscount.Size = new System.Drawing.Size(92, 20);
            this.Paramscount.TabIndex = 5;
            // 
            // paramscountvalue
            // 
            this.paramscountvalue.Location = new System.Drawing.Point(266, 138);
            this.paramscountvalue.MaxLength = 3;
            this.paramscountvalue.Name = "paramscountvalue";
            this.paramscountvalue.Size = new System.Drawing.Size(92, 20);
            this.paramscountvalue.TabIndex = 6;
            this.paramscountvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paramscountvalue_KeyPress);
            // 
            // timeValue
            // 
            this.timeValue.Location = new System.Drawing.Point(266, 56);
            this.timeValue.MaxLength = 4;
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(92, 20);
            this.timeValue.TabIndex = 7;
            this.timeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "=";
            // 
            // XmlMethodRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 217);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeValue);
            this.Controls.Add(this.paramscountvalue);
            this.Controls.Add(this.Paramscount);
            this.Controls.Add(this.Methodname);
            this.Controls.Add(this.packagevalue);
            this.Controls.Add(this.Package);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.nameValue);
            this.MaximumSize = new System.Drawing.Size(425, 256);
            this.MinimumSize = new System.Drawing.Size(425, 256);
            this.Name = "XmlMethodRedactor";
            this.Text = "XmlMethodRedactor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XmlMethodRedactor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Package;
        private System.Windows.Forms.TextBox packagevalue;
        private System.Windows.Forms.TextBox Methodname;
        private System.Windows.Forms.TextBox Paramscount;
        private System.Windows.Forms.TextBox paramscountvalue;
        private System.Windows.Forms.TextBox timeValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}