using ListViewUI.Models;
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
    public partial class fStudent : Form
    {
        public fStudent()
        {
            InitializeComponent();
            loadListView();
        }
        List<Student> listStudent;
        string idStudent;
        private void loadListView()
        {
            //set listview to detail
            lsvStudent.View = View.Details;
            //set displaying the gridlines
            lsvStudent.GridLines = true;
            //set fullRowSelect
            lsvStudent.FullRowSelect = true;

            //add columns to list view
            lsvStudent.Columns.Add("Id", 20, HorizontalAlignment.Left);
            lsvStudent.Columns.Add("Name", 20, HorizontalAlignment.Left);
            lsvStudent.Columns.Add("Age", 20, HorizontalAlignment.Left);

            //set autosize the length of column by the max length item
            lsvStudent.Columns[0].Width = -2;
            lsvStudent.Columns[1].Width = -2;
            lsvStudent.Columns[2].Width = -2;

            //add list student to listview
            addListStudents();
        }

        private void addListStudents()
        {
            listStudent = new List<Student>()
            {
                new Student("001", "Nguyen An", 18),
                new Student("002", "Nguyen Binh", 18),
                new Student("003", "Nguyen Huy", 18)
            };
            //listStudent.Add(new Student("001", "Nguyen An", 18));

            foreach(Student studentItem in listStudent)
            {
                //create a listview item object
                ListViewItem lsvItem = new ListViewItem(studentItem.id);

                //add subitem to listview item
                lsvItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text=studentItem.name});
                lsvItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = studentItem.age + "" });
                
                //add listview item to listview
                lsvStudent.Items.Add(lsvItem);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void fStudent_Load(object sender, EventArgs e)
        {

        }

        private void lsvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvStudent.SelectedItems[0];
                txtName.Text = item.SubItems[1].Text;
                txtId.Text = item.Text;
                txtAge.Text = item.SubItems[2].Text;
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student;
            int age;
            if(int.TryParse(txtAge.Text,out age))
            {
                student = new Student(txtId.Text, txtName.Text, age);
                if (!isStudentExisted(student.id))
                {
                    listStudent.Add(student);
                    showListStudents();
                }
                
            }
        }

        private bool isStudentExisted(string id)
        {
            foreach(Student studentItem in listStudent)
            {
                if (studentItem.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void showListStudents()
        {
            lsvStudent.Items.Clear();
            foreach(Student studentItem in listStudent)
            {
                ListViewItem lsvItem = new ListViewItem(studentItem.id);
                lsvItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = studentItem.name });
                lsvItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = studentItem.age +"" });

                lsvStudent.Items.Add(lsvItem);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            idStudent = txtId.Text;
            editStudentById(idStudent);
        }

        private void editStudentById(string idStudent)
        {
            if (!isStudentExisted(idStudent)) return;
            foreach(Student studentItem in listStudent)
            {
                if (studentItem.id == idStudent)
                {
                    studentItem.name = txtName.Text;
                    int age;
                    if(int.TryParse(txtAge.Text,out age))
                    {
                        studentItem.age = age;
                    }
                    break;
                }
            }
            showListStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            idStudent = txtId.Text;
            if (!isStudentExisted(idStudent)) return;
            deleteStudent(idStudent);
            showListStudents();
        }

        private void btnDeleteMultiple_Click(object sender, EventArgs e)
        {
            List<string> arrId = new List<string>();
            foreach(ListViewItem item in lsvStudent.SelectedItems)
            {
                arrId.Add(item.Text);
            }
            foreach(string id in arrId)
            {
                deleteStudent(id);
            }
            showListStudents();
        }

        private void deleteStudent(string id)
        {
            foreach(Student studentItem in listStudent)
            {
                if(studentItem.id == id)
                {
                    listStudent.Remove(studentItem);
                    break;
                }
            }
        }
    }
}
