using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeitErfassung
{
    public partial class Form2 : Form
    {
        public Form1 frm;
        public int time;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            frm = form1;
        }

        public void hours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                silly_error_label.Text = "";
                time = int.Parse(hours.Text);
            }
            catch
            {
                silly_error_label.Text = "pwease enter valid time >:(";
                hours.Text = "";
            }
        }

    }
}
