using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeitErfassung
{
    public partial class Form1 : Form
    {
        public TimeSpan Start;
        public TimeSpan breakStart;
        public TimeSpan breakEnd;
        public TimeSpan End;
        public TimeSpan addBreak;
        public TimeSpan addHours;
        public TimeSpan leaveTime;
        public Form1()
        {
            InitializeComponent();
        }
        public void calculateBs()
        {
            addHours = new TimeSpan(8, 0, 0);
            addBreak = (breakStart - breakEnd).Negate();
            leaveTime = Start.Add(addHours).Add(addBreak);
            LeaveTime.Value = DateTime.Parse(leaveTime.ToString());
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Start = StartTimePicker.Value.TimeOfDay;
            calculateBs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            if (breakStart != null && breakEnd != null)
            {
                calculateBs();
                breakStartLabel.Text = Convert.ToString(breakStart);
                breakEndLabel.Text = Convert.ToString(breakEnd);
            }
        }
    }
}
