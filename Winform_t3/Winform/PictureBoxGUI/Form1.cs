using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if(open.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = new Bitmap(open.FileName);
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                txtPath.Text = open.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.Copy(txtPath.Text, Path.Combine(@"D:\Winform\Winform\PictureBoxGUI\Images\",
                Path.GetFileName(txtPath.Text)),true);
            MessageBox.Show("Sucessfully!");
        }
    }
}
