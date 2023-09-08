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
        public TimeSpan addHours;
        public TimeSpan leaveTime;
        public TimeSpan totalBreakTime;
        public List<TimeSpan> addBreakList = new List<TimeSpan>();
        public Form1()
        {
            InitializeComponent();
        }
        public void calculateBs()
        {
            addHours = new TimeSpan(8, 0, 0);
            if (addBreakList != null)
            {
                foreach (TimeSpan t in addBreakList)
                {
                    totalBreakTime += t;
                }
                TimeSpan leaveTimeWithNoBreak = Start.Add(addHours);
                leaveTime = leaveTimeWithNoBreak + totalBreakTime;
                totalBreakTime = TimeSpan.Parse("00:00:00");
            }
            else
            {
                leaveTime = Start.Add(addHours);
            }
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
                Breaks breaks = new Breaks();
                breaks.StartTime = breakStart;
                breaks.EndTime = breakEnd;
                breaks.timeSpanList = addBreakList;
                breaks.addBreaks();

                for (int i = 0; i = (addBreakList + 1); i++)
                {
                    // 
                    // breakStartLabel
                    // 
                    breakStartLabel[addBreakList.Count].AutoSize = true;
                breakStartLabel[addBreakList.Count].Location = new System.Drawing.Point(24, 53);
                breakStartLabel[addBreakList.Count].Name = "breakStartLabel";
                breakStartLabel[addBreakList.Count].Size = new System.Drawing.Size(0, 13);
                breakStartLabel[addBreakList.Count].TabIndex = 3;
                // 
                // breakEndLabel
                // 
                breakEndLabel[addBreakList.Count].AutoSize = true;
                breakEndLabel[addBreakList.Count].Location = new System.Drawing.Point(24, 81);
                breakEndLabel[addBreakList.Count].Name = "breakEndLabel";
                breakEndLabel[addBreakList.Count].Size = new System.Drawing.Size(0, 13);
                breakEndLabel[addBreakList.Count].TabIndex = 4;

                breakStartLabel[addBreakList.Count].Text = Convert.ToString(breakStart);
                breakEndLabel[addBreakList.Count].Text = Convert.ToString(breakEnd);
            }
            calculateBs();
        }
    }
    class Breaks
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public List<TimeSpan> timeSpanList { get; set; }
        public void addBreaks()
        {
            TimeSpan addBreak = (StartTime - EndTime).Negate();

            timeSpanList.Add(addBreak);
        }
    }
}
