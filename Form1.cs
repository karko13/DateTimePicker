using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_TimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vrijeme_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime dt1 = datum.Value;
            StringBuilder sb1 = new StringBuilder();
        }

        private void gumb_Click(object sender, EventArgs e)
        {
            DateTime dt1 = datum.Value;
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Vas datum leta je:\n");

            sb1.Append(dt1.ToShortDateString() + "\n");

            DateTime dt2 = vrijeme.Value;

            sb1.Append("Vase vrijeme polaska je:  \n");

            sb1.Append(dt2.ToShortTimeString());



            richTextBox1.AppendText(sb1.ToString());
        }
    }
}
