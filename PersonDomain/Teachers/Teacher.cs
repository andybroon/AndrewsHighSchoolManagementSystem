using System;
using PersonDomain.PersonIdFactory;

namespace PersonDomain.Teachers
{
    public class Teacher : SchoolMember, ITeacher
    {
        public Teacher(DateTime dateOfBirth, DateTime dateStarted) 
            : base(new TeacherIdFactory(), dateStarted, dateOfBirth)
        {
        }

        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}