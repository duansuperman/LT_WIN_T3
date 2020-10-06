using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_PanelLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int i = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Button " + i++;
            btn.BackColor = Color.Green;
            btn.Width = 50;
            btn.Height = 50;

            Random rd = new Random();
            btn.Location = new Point(rd.Next(1, pnlButton.Size.Width), rd.Next(1, pnlButton.Size.Height));

            pnlButton.Controls.Add(btn);
        }
    }
}
