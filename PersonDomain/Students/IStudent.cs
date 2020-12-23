namespace PersonDomain.Students
{
    public interface IStudent : ISchoolMember
    {
        string CurrentYear { get; }
        string Grade { get; }
        decimal Gpa { get; }
    }
}