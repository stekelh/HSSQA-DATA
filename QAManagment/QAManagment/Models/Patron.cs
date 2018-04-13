using System;
using System.Collections.Generic;
using System.Text;  

namespace QAManagment.Models
{
    public class Patron
    {
            public int id {get; set;}
            public string FirstName { get; set;}
            public string  LastName {get; set;}
            public string Address {get; set;}
            public DateTime DateOfBirth { get; set;}
            public  string PhoneNumber { get; set;}

            //public virtual IDCard IDCard {get; set;}

    }
}