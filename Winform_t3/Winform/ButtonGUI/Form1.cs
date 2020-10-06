using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnNew = new Button();
            btnNew.Text = "New button";
            btnNew.Width = 50;
            btnNew.Height = 50;

            Random rd = new Random();

            int x = rd.Next(1, 50);
            int y = rd.Next(100, 500);

            btnNew.Location = new Point(x,y);

            this.Controls.Add(btnNew);
        }
        
        

        
    }
}
