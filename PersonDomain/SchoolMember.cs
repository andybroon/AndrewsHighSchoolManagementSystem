using System;
using System.ComponentModel.DataAnnotations;
using PersonDomain.PersonIdFactory;
using Utility;

namespace PersonDomain
{
    public abstract class SchoolMember : Person, ISchoolMember
    {
        protected SchoolMember(IIdFactory idFactory, DateTime dateStarted, DateTime dateOfBirth) : base(dateOfBirth, idFactory)
        {
            DateStarted = dateStarted;
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = DateFormats.DateWithSlashes, ApplyFormatInEditMode = true)]
        public DateTime DateStarted { get; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = DateFormats.DateWithSlashes, ApplyFormatInEditMode = true)]
        public DateTime? DateFinished { get; set; }
    }
}