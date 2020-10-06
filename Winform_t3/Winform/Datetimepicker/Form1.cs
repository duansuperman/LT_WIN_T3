using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            //show date
            MessageBox.Show(dateTime.ToShortDateString());
            //show day
            MessageBox.Show(dateTime.Day.ToString());
            //show day of week
            MessageBox.Show(dateTime.DayOfWeek.ToString());
            //show time of  current day
            MessageBox.Show(dateTime.TimeOfDay.ToString());
        }
    }
}
