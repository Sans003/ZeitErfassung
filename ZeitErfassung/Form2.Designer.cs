namespace ZeitErfassung
{
    partial class Form2
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
            this.hours = new System.Windows.Forms.TextBox();
            this.silly_error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Breaktime (in minutes)";
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(56, 59);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(100, 20);
            this.hours.TabIndex = 3;
            this.hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hours.TextChanged += new System.EventHandler(this.hours_TextChanged);
            // 
            // silly_error_label
            // 
            this.silly_error_label.AutoSize = true;
            this.silly_error_label.Location = new System.Drawing.Point(44, 38);
            this.silly_error_label.Name = "silly_error_label";
            this.silly_error_label.Size = new System.Drawing.Size(0, 13);
            this.silly_error_label.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 91);
            this.Controls.Add(this.silly_error_label);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.Label silly_error_label;
    }
}