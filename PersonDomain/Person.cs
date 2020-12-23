using System.Collections.Generic;
using PersonDomain.PersonIdFactory;

namespace PersonDomain
{
    public abstract class Person : IPerson
    {
        protected Person(IIdFactory idFactory)
        {
            Id = idFactory.CreateId();
        }

        public string Id { get; }
        public IEnumerable<string> GivenNames { get; set; }
        public string Surname { get; set; }
        public Address HomeAddress { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
