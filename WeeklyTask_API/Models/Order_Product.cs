using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyTask_API.Models
{
    public class Order_Product
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductCode { get; set; }
        public int Qty { get; set; }
        public int PriceEach { get; set; }

        // public Order order { get; set; }

        // public Product product { get; set; }
    }
}