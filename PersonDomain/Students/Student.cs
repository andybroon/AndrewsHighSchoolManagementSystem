using System;
using PersonDomain.PersonIdFactory;

namespace PersonDomain.Students
{
    class Student : SchoolMember, IStudent
    {
        public Student(DateTime dateStarted, DateTime dateOfBirth) 
            : base(new StudentIdFactory(), dateStarted, dateOfBirth)
        {
        }

        public string CurrentYear { get; }
        public string Grade { get; }
        public decimal Gpa { get; }
    }
}