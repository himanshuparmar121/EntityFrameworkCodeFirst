using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeFirst.Models 
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String FirstName { get; set; }
  
        [Required]
        [MaxLength(50)]
        public String LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(100)]
        public String EmailAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public String Department { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    } 
}