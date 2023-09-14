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
        public TimeSpan End;
        public TimeSpan addHours;
        public TimeSpan leaveTime;
        public TimeSpan TotalBreakTime;
        public TimeSpan TotalWorkTime;
        public Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }
        public void calculateBs()
        {
            addHours = new TimeSpan(8, 0, 0);
            if (form2 != null)
            {
                TotalBreakTime += TimeSpan.FromMinutes(form2.time);
                breakTimeDisplay.Text = $"Breaks Today in Minutes:\n{TotalBreakTime.TotalMinutes}";
            }
            TotalWorkTime = addHours.Add(TotalBreakTime);
            LeaveTime.Value = DateTime.Parse(Convert.ToString(Start.Add(TotalWorkTime)));

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Start = StartTimePicker.Value.TimeOfDay;
            calculateBs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.ShowDialog();
            calculateBs();
        }

    }
}
