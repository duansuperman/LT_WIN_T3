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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string strStudent = ckbStudent.CheckState == CheckState.Checked ? "là học sinh" :
                ckbStudent.CheckState == CheckState.Unchecked ? "không là học sinh" : "là cũng không là học sinh";
            string strShow = string.Format("Chào bạn, bạn {0}", strStudent);
            MessageBox.Show(strShow);
        }
    }
}
