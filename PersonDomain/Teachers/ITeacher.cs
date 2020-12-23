namespace PersonDomain.Teachers
{
    public interface ITeacher : ISchoolMember
    {
        decimal Salary { get; set; }
        string Department { get; set; }
    }
}