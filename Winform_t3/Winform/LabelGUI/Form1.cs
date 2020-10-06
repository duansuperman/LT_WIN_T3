using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGUI
{
    public partial class fLogin : Form
    {
        string userName, passWord;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Yellow;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUsername.Text;
            passWord = txtPassword.Text;

            MessageBox.Show("Username = " + userName + "\n Password = " + passWord);
        }
    }
}
