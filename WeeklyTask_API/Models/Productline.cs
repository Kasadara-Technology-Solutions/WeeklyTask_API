using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyTask_API.Models
{
    public class Productline
    {
        public int ID { get; set; }
        public string DesclnText { get; set; }
        public string DesclnHTML { get; set; }
        public string Image { get; set; }
        public ICollection<Product> products { get; set; }
    }
}