namespace ZeitErfassung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LeaveTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "HH:mm";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(12, 12);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(65, 20);
            this.StartTimePicker.TabIndex = 0;
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LeaveTime
            // 
            this.LeaveTime.CustomFormat = "HH:mm";
            this.LeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.LeaveTime.Location = new System.Drawing.Point(12, 128);
            this.LeaveTime.Name = "LeaveTime";
            this.LeaveTime.ShowUpDown = true;
            this.LeaveTime.Size = new System.Drawing.Size(65, 20);
            this.LeaveTime.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Break";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LeaveTime);
            this.Controls.Add(this.StartTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker LeaveTime;
        private System.Windows.Forms.Button button1;
    }
}

