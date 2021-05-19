using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyTask_API.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public Customer customer { get; set; }
        public virtual List<Order_Product> Order_Products { get; set; }

    }
}