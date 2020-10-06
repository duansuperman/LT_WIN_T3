using DataGridview.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridview
{
    public partial class Form1 : Form
    {
        List<Person> listPerson;
        int currentRow, currentColumn;
        string valueCell;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setFullRowSelect();
            //setRealOnly();
            initializeData();
            fetchData();
        }

        private void fetchData()
        {
            Console.WriteLine(dtgvPerson.RowCount);
            for(int i = 0; i < dtgvPerson.RowCount-1; i++)
            {
                string id = dtgvPerson.Rows[i].Cells[0].Value.ToString();
                string name = dtgvPerson.Rows[i].Cells[1].Value.ToString();
                string age = dtgvPerson.Rows[i].Cells[2].Value.ToString();
                Console.WriteLine(id+" "+name+" "+age);
            }
            
        }

        private void setRealOnly()
        {
            dtgvPerson.ReadOnly = true;
        }

        private void setFullRowSelect()
        {
            dtgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       
        private void initializeData()
        {
            string[] row0 = { "1", "Nguyen Anh", "20" };
            string[] row1 = { "2", "Nguyen Binh", "21" };
            string[] row2 = { "3", "Nguyen Bao", "22" };

            dtgvPerson.Rows.Add(row0);
            dtgvPerson.Rows.Add(row1);
            dtgvPerson.Rows.Add(row2);
        }

        private void dtgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = dtgvPerson.CurrentCell.RowIndex;
            currentColumn = dtgvPerson.CurrentCell.ColumnIndex;
            MessageBox.Show("Current row ="+currentRow+"\n"+"Current Cell ="+currentColumn);

            valueCell = dtgvPerson.CurrentCell.Value.ToString();
            MessageBox.Show(valueCell);

        }

        private void dtgvPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dtgvPerson.Rows.RemoveAt(currentRow);
            }
        }
    }
}
