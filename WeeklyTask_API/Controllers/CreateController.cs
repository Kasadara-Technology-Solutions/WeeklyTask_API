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
    public class CreateController : ApiController
    {
        Create_Service Call_Func = new Create_Service();

        // CREATE : Order

        [HttpPost]
        [ActionName("CreateOrder")]
        public IHttpActionResult CreateOrder([FromBody] Order order)
        {
            Call_Func.CreateOrder(order);
            return Created<Order>("Created Successfully", order);
        }

        // CREATE : Product

        [HttpPost]
        [ActionName("CreateProduct")]
        public IHttpActionResult CreateProduct([FromBody] Product product)
        {
            Call_Func.CreateProduct(product);
            return Created<Product>("Created Succesfully", product);
        }

        // CREATE : Customer

        [HttpPost]
        [ActionName("CreateCustomer")]
        public IHttpActionResult CreateCustomer([FromBody] Customer customer)
        {
            Call_Func.CreateCustomer(customer);
            return Created<Customer>("Created Succesfully", customer);
        }

        // CREATE : Payment

        [HttpPost]
        [ActionName("CreatePayment")]
        public IHttpActionResult CreatePayment([FromBody] Payment payment)
        {
            Call_Func.CreatePayment(payment);
            return Created<Payment>("Created Succesfully", payment);
        }

        // CREATE : Office

        [HttpPost]
        [ActionName("CreateOffice")]
        public IHttpActionResult CreateOffice([FromBody] Office office)
        {
            Call_Func.CreateOffice(office);
            return Created<Office>("Created Succesfully", office);
        }

        // CREATE : Employee

        [HttpPost]
        [ActionName("CreateEmployee")]
        public IHttpActionResult CreateEmployee([FromBody] Employee employee)
        {
            Call_Func.CreateEmployee(employee);
            return Created<Employee>("Created Succesfully", employee);
        }

    }
}
