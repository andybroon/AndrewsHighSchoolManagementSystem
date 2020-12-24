using System.Collections.Generic;

namespace SchoolDomain
{
    public interface IDepartment
    {
        string Name { get; }
        string DepartmentHeadId { get; }
        IEnumerable<string> Teachers { get; }
    }
}