using System;
using System.Collections.Generic;

namespace Topicos.Sakila.Model.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
        }

        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; }
        public int AddressId { get; set; }
        public string Active { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
