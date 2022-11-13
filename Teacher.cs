using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForUniversity
{
    public class Teacher
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private Subject[] _subjectsTeaching = new Subject[3];

        private int _current = 0;

        public Teacher(string firstName, string lastName, Subject[] subjectsTeaching, int current)
        {
            FirstName = firstName;
            LastName = lastName;
            _subjectsTeaching = subjectsTeaching;
            _current = current;
        }

        public Teacher()
        {
        }

        public override string ToString()
        {
            StringBuilder teacherAsString = new StringBuilder();
            teacherAsString.Append("subjects teaching:" + _subjectsTeaching);
            return teacherAsString.ToString();
        }


        public void AddSubject(Subject subject)
        {
            if (!_subjectsTeaching.Contains(subject) && _current + 1 != _subjectsTeaching.Length - 1)
            {
                _subjectsTeaching[_current++] = subject;
            }
        }

        public void ChangeSubjects(Subject previousSubject, Subject newSubject)
        {
            if (_subjectsTeaching[_current] == previousSubject && !_subjectsTeaching.Contains(previousSubject))
            {
                _subjectsTeaching[_current] = newSubject;   
            }
        }
    }
}
