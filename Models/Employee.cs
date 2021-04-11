using System;
using System.Collections.Generic;

namespace EntityFrameworkCodeFirst.Models 
{
    public class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public String EmailAddress { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    } 
}