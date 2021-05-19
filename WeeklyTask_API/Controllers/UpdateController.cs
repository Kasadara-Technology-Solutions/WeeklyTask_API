using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeeklyTask_API.Models;
using WeeklyTask_API.Services;

namespace WeeklyTask_API.Controllers
{
    public class UpdateController : ApiController
    {
        Edit_Service Call_Func = new Edit_Service();

        // UPDATE : Order 

        [HttpPut]
        [ActionName("UpdateOrder")]
        public IHttpActionResult EditOrder([FromBody] Order order)
        {
            Call_Func.EditOrder(order);
            return Created<Order>("Created Successfully", order);
        }

        // UPDATE : Product

        [HttpPut]
        [ActionName("UpdateProduct")]
        public IHttpActionResult EditProduct([FromBody] Product product)
        {
            Call_Func.EditProduct(product);
            return Created<Product>("Created Successfully", product);
        }

        // UPDATE : Customer 

        [HttpPut]
        [ActionName("UpdateCustomer")]
        public IHttpActionResult EditCustomer([FromBody] Customer customer)
        {
            Call_Func.EditCustomer(customer);
            return Created<Customer>("Created Successfully", customer);
        }

    }
}
