using System;
using PersonDomain.PersonIdFactory;

namespace PersonDomain
{
    public abstract class SchoolMember : Person, ISchoolMember
    {
        protected SchoolMember(IIdFactory idFactory, DateTime dateStarted) : base(idFactory)
        {
            DateStarted = dateStarted;
        }

        public DateTime DateStarted { get; }
        public DateTime? DateFinished { get; set; }
    }
}