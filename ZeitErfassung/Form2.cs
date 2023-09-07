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
    public partial class Form2 : Form
    {
        public Form1 frm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            frm = form1;
        }

        private void breakStartPicker_ValueChanged(object sender, EventArgs e)
        {
            frm.breakStart = breakStartPicker.Value.TimeOfDay;
        }

        private void breakEndPicker_ValueChanged(object sender, EventArgs e)
        {
            frm.breakEnd = breakEndPicker.Value.TimeOfDay;
        }
    }
}
