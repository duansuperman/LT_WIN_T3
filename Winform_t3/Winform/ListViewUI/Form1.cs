using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setSignleSelect();
            setFullRowSelect();
        }
        int index;
        private void setFullRowSelect()
        {
            lsvShow.FullRowSelect = true;
        }

        private void setSignleSelect()
        {
            lsvShow.MultiSelect = false;
        }

        private void lsvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                
                //get the index of the current selection
                index = lsvShow.SelectedIndices[0];
                MessageBox.Show("Index = "+index + "");

                //get the content of item parent
                MessageBox.Show("The content of item parent = " + lsvShow.SelectedItems[0].Text);

                //get the index of image which set for the item parent
                MessageBox.Show("Index of image = " + lsvShow.SelectedItems[0].ImageIndex);

                //get the content of subitem at index 1
                MessageBox.Show("Content of subitem = " + lsvShow.SelectedItems[0].SubItems[1].Text);

                //checking if the item has been checked
                MessageBox.Show(lsvShow.SelectedItems[0].Checked == true ? "True" : "False");
            }
            catch
            {
                Console.WriteLine("No item selected");
            }
            
        }

        private void btnShowSelectedItem_Click(object sender, EventArgs e)
        {
            string strShow = "";
            foreach(ListViewItem item in lsvShow.Items)
            {
                if (item.Checked)
                {
                    strShow += item.Text + "\n";
                }
            }
            MessageBox.Show("The list item selected :\n" + strShow);
        }

        private void lsvShow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                lsvShow.SelectedItems[0].Remove();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lsvShow.SelectedItems[0].Remove();
        }
    }
}
