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
    public partial class Form2 : Form
    {
        List<Person> listPerson;
        int currentRow, currentColumn;
        int id, age;
        string name;
        public Form2()
        {
            InitializeComponent();
            initializeData();
            //fillDataToDataGridView();
        }

        private void fillDataToDataGridView()
        {
            dtgvPerson.Rows.Clear();
            for(int i = 0; i < listPerson.Count; i++)
            {
                Object[] row = { listPerson[i].id , listPerson[i].name, listPerson[i].age };
                dtgvPerson.Rows.Add(row);
            }
        }

        private void dtgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = dtgvPerson.SelectedCells[0].RowIndex;
            if(dtgvPerson.Rows[currentRow].Cells[0].Value!=null)
            {
                id = int.Parse(dtgvPerson.Rows[currentRow].Cells[0].Value.ToString());
            }
        }

        private void dtgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtID.Text);
            name = txtName.Text;
            age = int.Parse(txtAge.Text);

            Person newPerson = new Person(id, name, age);
            listPerson.Add(newPerson);

            dtgvPerson.DataSource = null;
            dtgvPerson.DataSource = listPerson;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtID.Text);
            name = txtName.Text;
            age = int.Parse(txtAge.Text);

            foreach (Person item in listPerson)
            {
                if(item.id == id)
                {
                    item.name = name;
                    item.age = age;
                }
            }
            dtgvPerson.DataSource = null;
            dtgvPerson.DataSource = listPerson;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtID.Text);
            foreach(Person item in listPerson)
            {
                if(item.id == id)
                {
                    listPerson.Remove(item);
                    break;
                }
            }
            dtgvPerson.DataSource = null;
            dtgvPerson.DataSource = listPerson;
        }

        private void initializeData()
        {
            listPerson = new List<Person>();

            Person person1 = new Person(1,"Jonh", 20);
            Person person2 = new Person(2, "Jolie", 25);
            Person person3 = new Person(3, "Jame", 21);

            listPerson.Add(person1);
            listPerson.Add(person2);
            listPerson.Add(person3);

            dtgvPerson.DataSource = listPerson;
        }

        private void dtgvPerson_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dtgvPerson.Rows[currentRow].Cells[0].Value == null ||
                    dtgvPerson.Rows[currentRow].Cells[1].Value == null ||
                    dtgvPerson.Rows[currentRow].Cells[2].Value == null) return;

                if (int.TryParse(dtgvPerson.Rows[currentRow].Cells[0].Value.ToString(), out id) &&
                   int.TryParse(dtgvPerson.Rows[currentRow].Cells[2].Value.ToString(), out age))
                {
                    name = dtgvPerson.Rows[currentRow].Cells[1].Value.ToString();
                    listPerson.Add(new Person(id, name, age));
                }

            }

            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < listPerson.Count; i++)
                {

                    if (listPerson[i].id == id)
                    {
                        listPerson.Remove(listPerson[i]);
                        break;
                    }
                }
            }
            fillDataToDataGridView();
        }

    }
}
