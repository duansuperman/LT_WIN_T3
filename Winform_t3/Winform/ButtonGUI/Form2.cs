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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            createListButton();
        }

        private void createListButton()
        {
            for(int i = 0; i <= 10; i++)
            {
                Button btnNew = new Button() { Text = "" + i, Width = 50, 
                    Height = 50, BackColor=Color.Green };
                btnNew.Click += BtnNew_Click;
                flpGroup.Controls.Add(btnNew);
            }
        }
        int j = 0;
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Button btnNew = sender as Button;
            if (j++ == 0)
            {
                btnNew.BackColor = Color.Yellow;
            }
            else
            {
                btnNew.BackColor = Color.Green;
                j = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
