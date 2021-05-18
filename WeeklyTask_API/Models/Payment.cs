using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyTask_API.Models
{
    public class Payment
    {
        public int CheckNum { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public string PaymentDate { get; set; }
        public int Amount { get; set; }
    }
}