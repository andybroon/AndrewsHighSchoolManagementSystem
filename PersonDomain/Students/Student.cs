using System;
using PersonDomain.PersonIdFactory;
using SchoolDomain;

namespace PersonDomain.Students
{
    class Student : SchoolMember, IStudent
    {
        public Student(DateTime dateStarted, DateTime dateOfBirth) 
            : base(new StudentIdFactory(), dateStarted, dateOfBirth)
        {
        }

        public string CurrentYear => DateFinished.HasValue ? "Graduated" : $"(S{(int)((DateTime.Now - DateStarted).TotalDays/365)}";
        public Grade Grade => StaticGradeCalculator.GetGrade(Gpa);
        public decimal Gpa { get; }
    }
}