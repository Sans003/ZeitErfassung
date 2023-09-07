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
            this.breakStartPicker = new System.Windows.Forms.DateTimePicker();
            this.breakEndPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breakStartPicker
            // 
            this.breakStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.breakStartPicker.Location = new System.Drawing.Point(80, 12);
            this.breakStartPicker.Name = "breakStartPicker";
            this.breakStartPicker.ShowUpDown = true;
            this.breakStartPicker.Size = new System.Drawing.Size(70, 20);
            this.breakStartPicker.CustomFormat = "HH:mm";
            this.breakStartPicker.TabIndex = 0;
            this.breakStartPicker.ValueChanged += new System.EventHandler(this.breakStartPicker_ValueChanged);
            // 
            // breakEndPicker
            // 
            this.breakEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.breakEndPicker.Location = new System.Drawing.Point(80, 55);
            this.breakEndPicker.Name = "breakEndPicker";
            this.breakEndPicker.ShowUpDown = true;
            this.breakEndPicker.Size = new System.Drawing.Size(70, 20);
            this.breakEndPicker.CustomFormat = "HH:mm";
            this.breakEndPicker.TabIndex = 1;
            this.breakEndPicker.ValueChanged += new System.EventHandler(this.breakEndPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Break Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Break End";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 91);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.breakEndPicker);
            this.Controls.Add(this.breakStartPicker);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker breakStartPicker;
        private System.Windows.Forms.DateTimePicker breakEndPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}