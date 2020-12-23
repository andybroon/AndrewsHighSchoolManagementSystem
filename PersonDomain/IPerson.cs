using System;
using System.Collections.Generic;

namespace PersonDomain
{
    public interface IPerson
    {
        string Id { get; }
        IEnumerable<string> GivenNames { get; set; }
        string Surname { get; set; }
        DateTime DateOfBirth { get; }
        Address HomeAddress { get; set; }
        string PrimaryPhoneNumber { get; set; }
        string SecondaryPhoneNumber { get; set; }
        string EmailAddress { get; set; }
    }
}