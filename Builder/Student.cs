using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Student
    {

        public Student(int studentID)
        {
            SudentID = studentID;
        }
        public int SudentID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }

        public string Mobile { get; set; }
        public string GetDetails()

        {

            return $" Name: {Name}\n Family: {Family}\n Age: {Age}\n Phone: {Phone}";

        }

    }
}
