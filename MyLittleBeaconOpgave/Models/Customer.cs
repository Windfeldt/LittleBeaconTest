using System;
using SQLite;
namespace MyLittleBeaconOpgave.Models
{
    public class Customer
    {

        public string Id { get; set; }
        public DateTime LastActivity { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }

        public Customer()
        {

        }
    }
}
