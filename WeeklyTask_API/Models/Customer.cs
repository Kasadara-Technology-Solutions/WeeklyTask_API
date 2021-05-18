using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyTask_API.Models
{
    public class Customer
    {
        public virtual ICollection<Payment> payments { get; set; }
        public int ID { get; set; }
        public int salesRepEmployeeNum { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FristName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CreditLimit { get; set; }
        public Employee employee { get; set; }
        public virtual ICollection<Order> orders { get; set; }
    }
}