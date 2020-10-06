using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class Form1 : Form
    {
        QLSVEntities db = new QLSVEntities();
        int currentRow;

        public Form1()
        {
            InitializeComponent();
            loadStudentData();
            loadDepartmentDataToCombobox();
        }

        private void loadDepartmentDataToCombobox()
        {
            List<Department> listDepartment = db.Departments.ToList();
            
            foreach(Department item in listDepartment)
            {
                cbDepartment.Items.Add(item.name);
            }
            //cbDepartment.SelectedIndex = 1;
        }

        private void loadStudentData()
        {
            //Clear data from the second loading
            dtgvStudent.Rows.Clear();

            List<Student> listStudent = db.Students.ToList();
            
            //Add student data into dtgvStudent
            foreach(Student item in listStudent)
            {
                //get department id of each student
                int departmentId = (int)item.Department_id;

                //Retrieve the corresponsive department 
                Department department = db.Departments.Where(w => w.id == departmentId).SingleOrDefault();

                string[] row = { item.id+"",item.name,item.age+"",
                    item.@class,department.name};

                dtgvStudent.Rows.Add(row);
            }
        }

        private void dtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = dtgvStudent.CurrentCell.RowIndex;

            txbID.Text = int.Parse(dtgvStudent.Rows[currentRow].Cells[0].Value.ToString())+"";
            txbName.Text = dtgvStudent.Rows[currentRow].Cells[1].Value.ToString();
            txbAge.Text = int.Parse(dtgvStudent.Rows[currentRow].Cells[2].Value.ToString()) + "";
            txbClass.Text = dtgvStudent.Rows[currentRow].Cells[3].Value.ToString();

            //Select the corresponsive department to fill in the student combobox
            cbDepartment.SelectedItem = dtgvStudent.Rows[currentRow].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            //id = int.Parse(txbID.Text);
            newStudent.name = txbName.Text;
            newStudent.age = int.Parse(txbAge.Text);
            newStudent.@class = txbClass.Text;

            //Get department via the department name
            string departmentName = cbDepartment.Text;
            Department department = db.Departments.Where(w => w.name == departmentName).SingleOrDefault();

            newStudent.Department_id = department.id;

            db.Students.Add(newStudent);
            db.SaveChanges();

            loadStudentData();
        }
    }
}
