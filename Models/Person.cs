using System;
using System.Collections.Generic;

namespace dotnetcorewebapi.Models
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }

    }
}