using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeFirst.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public String Street { get; set; }

        [Required]
        [MaxLength(100)]
        public String City { get; set; }

        [Required]
        [MaxLength(50)]
        public String State { get; set; }

        [Required]
        public long PinCode { get; set; }
    }
}