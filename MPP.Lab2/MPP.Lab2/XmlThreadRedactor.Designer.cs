namespace MPP.Lab2
{
    partial class XmlThreadRedactor
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
            this.ThreadId = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.TimeValue = new System.Windows.Forms.TextBox();
            this.Threadidvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThreadId
            // 
            this.ThreadId.Location = new System.Drawing.Point(12, 12);
            this.ThreadId.Name = "ThreadId";
            this.ThreadId.ReadOnly = true;
            this.ThreadId.Size = new System.Drawing.Size(100, 20);
            this.ThreadId.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(12, 47);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(100, 20);
            this.Time.TabIndex = 1;
            // 
            // TimeValue
            // 
            this.TimeValue.Location = new System.Drawing.Point(172, 47);
            this.TimeValue.MaxLength = 4;
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(65, 20);
            this.TimeValue.TabIndex = 2;
            this.TimeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeValue_KeyPress);
            // 
            // Threadidvalue
            // 
            this.Threadidvalue.Location = new System.Drawing.Point(172, 12);
            this.Threadidvalue.MaxLength = 3;
            this.Threadidvalue.Name = "Threadidvalue";
            this.Threadidvalue.Size = new System.Drawing.Size(65, 20);
            this.Threadidvalue.TabIndex = 3;
            this.Threadidvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Threadidvalue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ms";
            // 
            // XmlThreadRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Threadidvalue);
            this.Controls.Add(this.TimeValue);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.ThreadId);
            this.MaximumSize = new System.Drawing.Size(300, 153);
            this.MinimumSize = new System.Drawing.Size(300, 153);
            this.Name = "XmlThreadRedactor";
            this.Text = "XmlThreadRedactor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XmlThreadRedactor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThreadId;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox TimeValue;
        private System.Windows.Forms.TextBox Threadidvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}