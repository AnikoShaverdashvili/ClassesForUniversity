using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForUniversity
{
    public class Subject
    {
        public string Name { get; set; }
        public List<string> Prerequisitubjects { get; set; }
        public byte CreditForSubject
        {
            get
            {
                return CreditForSubject;
            }
            set
            {
                if (value < 3 && value > 7)
                {
                    throw new IndexOutOfRangeException("Subject credits can be 3,4,5,6,7");
                }
                CreditForSubject = value;
            }
        }
        public Subject()
        {

        }

        public Subject(string name, List<string> prerequisitubjects, byte creditForSubject)
        {
            Name = name;
            Prerequisitubjects = prerequisitubjects;
            CreditForSubject = creditForSubject;
        }

        public Subject(string name)
        {
            Name = name;
        }
    }
}

