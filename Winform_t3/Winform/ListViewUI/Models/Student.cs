using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewUI.Models
{
    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Student()
        {

        }
        public Student(string id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
}
