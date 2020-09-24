using System;
using System.Collections.Generic;
using System.Text;

namespace Practical4Ex2
{
    interface IStudentMark
    {
        public string Fullname { set; get; }
        public int Id { set; get; }
        public string Class { set; get; }
        public int Semester { set; get; }
        public float Averagemark { set; get; }

        public void Display() { }
    }
}
