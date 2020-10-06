using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckbMale_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckedChanged");
        }

        private void ckbMale_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckStateChanged");
        }

        private void ckbMale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}
