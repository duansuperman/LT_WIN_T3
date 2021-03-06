﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Project
{
    public partial class Form1 : Form
    {
        HR_dbEntities db = new HR_dbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Select(s => new
            {
                id = s.id,
                name = s.name,
                department = s.Department.name
            }).ToList();
        }
    }
}
