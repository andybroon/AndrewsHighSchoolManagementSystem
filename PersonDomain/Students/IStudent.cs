using SchoolDomain;

namespace PersonDomain.Students
{
    public interface IStudent : ISchoolMember
    {
        string CurrentYear { get; }
        Grade Grade { get; }
        decimal Gpa { get; }
    }
}