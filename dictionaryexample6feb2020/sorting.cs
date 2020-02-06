using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    public class student:IComparable<student>
    {
        public int studtid { get; set; }
        public string studname { get; set; }
        public int marks { get; set; }
        public string dob { get; set; }

        public int CompareTo(student other)
        {
            if (this.studtid > other.studtid)
            {
                return 1;
            }else if (this.studtid < other.studtid)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class comparestudents : IComparer<student>
    {
        public int Compare(student x, student y)
        {
            if (x.marks > y.marks)
            {
                return 1;
            }
            else if (x.marks < y.marks)
            {
                return -1;
            }else
            {
                return 0;
            }
        }
    }
    class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            
            student s1 = new student { studtid = 34, studname = "dinesh", marks = 4000, dob = "29/12/1999" };
            student s2 = new student { studtid = 47, studname = "baiju", marks = 40000, dob = "28/11/1999" };
            student s3 = new student { studtid = 23, studname = "suresh", marks = 47000, dob = "27/10/1998" };
            student s4 = new student { studtid = 32, studname = "manas", marks = 45000, dob = "26/18/1994" };
            List<student> students = new List<student>() { s1, s2, s3, s4 };
            comparestudents onj = new comparestudents();
            students.Sort(onj);

            foreach (student obj in students)
            {
                log.Info(obj.studtid + " " + obj.studname + " " + obj.marks  + " " + obj.dob);
            }
            Console.ReadLine();


        }
    }
}
