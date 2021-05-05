using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        private string name;
        private int id;

        public Student()
        {
            this.name = "nothing";
            this.id = 0;
        }
        /// <summary>
        /// Parameter descreption
        /// </summary>
        /// <param name="id">the student id</param>
        /// <param name="name">the student name</param>
        public Student(int id , string name)
        {
            this.name = name;
            this.id = id;
        }

        public void setname (string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }

        public int StudentId
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public override string ToString()
        {
            return $"Name: {this.name} \nID: {this.id}";
        }
    }
}
