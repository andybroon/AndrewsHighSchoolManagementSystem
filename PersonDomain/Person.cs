using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PersonDomain.PersonIdFactory;
using Utility;

namespace PersonDomain
{
    public abstract class Person : IPerson
    {
        protected Person(DateTime dateOfBirth, IIdFactory idFactory)
        {
            Id = idFactory.CreateId();
            DateOfBirth = dateOfBirth;
        }

        public string Id { get; }
        public IEnumerable<string> GivenNames { get; set; }
        public string Surname { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = DateFormats.DateWithSlashes, ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; }

        public Address HomeAddress { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
