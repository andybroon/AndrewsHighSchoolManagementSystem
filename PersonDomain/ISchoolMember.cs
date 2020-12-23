using System;

namespace PersonDomain
{
    public interface ISchoolMember : IPerson
    {
        DateTime DateStarted { get; }
        DateTime? DateFinished { get; set; }
    }
}