using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
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
            List<Employee> list = db.Employees.ToList();
            foreach(Employee em in list)
            {
                Console.WriteLine(em.name);
            }
        }
    }
}
