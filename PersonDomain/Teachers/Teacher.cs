using System;
using PersonDomain.PersonIdFactory;

namespace PersonDomain.Teachers
{
    public class Teacher : SchoolMember, ITeacher
    {
        public Teacher(DateTime dateStarted) 
            : base(new TeacherIdFactory(), dateStarted)
        {
        }

        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}