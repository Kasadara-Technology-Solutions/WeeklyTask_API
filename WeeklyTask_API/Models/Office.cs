using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyTask_API.Models
{
    public class Office
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string Territory { get; set; }
        public ICollection<Employee> employees { get; set; }
    }
}