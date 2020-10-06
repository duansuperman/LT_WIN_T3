using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Button "+i++;
            btn.BackColor = Color.Green;
            btn.Click += Btn_Click;

            //flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }
    }
}
