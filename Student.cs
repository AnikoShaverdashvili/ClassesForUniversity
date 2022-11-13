using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesForUniversity
{
    public  class Student
    {     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public Teacher Teacher { get; set; }
        public Semester SemesterForStudents { get; set; }

        private const int MaxCredits = 35;
       
        private Subject[] _subjectsStuding = new Subject[3];        
        public string PIN
        {
            get
            {
                return PIN;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("PIN should be 11 symbols long ");
                }
                PIN = value;
            }

        }
        public int Credits
        {
            get
            {
                return Credits;
            }
            set
            {
                if (value > 35)
                {
                    throw new IndexOutOfRangeException("Student can't earn more than 35 academic credits");
                }
                Credits = value;
            }
        }

        public Student(string firstName, string lastName, Teacher teacher, Semester semesterForStudents, Subject[] subjectsStuding, string pIN, int credits)
        {
            FirstName = firstName;
            LastName = lastName;
            Teacher = teacher;
            SemesterForStudents = semesterForStudents;
            _subjectsStuding = subjectsStuding;
            PIN = pIN;
            Credits = credits;
        }

        public Student()
        {
        }


        public void InformationAboutTeachers()
        {
            Console.WriteLine(Teacher);
        }


        public void PrintSubjects()
        {
            for(int i = 0; i < _subjectsStuding.Length; i++)
            {
                Console.WriteLine(_subjectsStuding[i]);
            }
        }

        public override string ToString()
        {
            StringBuilder StudentAsString = new StringBuilder();
            StudentAsString.AppendLine($"Students Name {FullName}");
            StudentAsString.Append($"subjects Learning: {_subjectsStuding}");
            return StudentAsString.ToString();
        }

    }
}
