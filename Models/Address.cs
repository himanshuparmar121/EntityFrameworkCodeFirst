using System;

namespace EntityFrameworkCodeFirst.Models
{
    public class Address
    {
        public int Id { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public long PinCode { get; set; }
    }
}