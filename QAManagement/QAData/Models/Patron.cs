using System;
using System.Collections.Generic;
using System.Text;

namespace QAData.Models
{
    public class Patron
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public virtual QACard QACard {get; set;}
        public virtual QABranch QAHome {get; set;}

    }
}