using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeeklyTask_API.Services;

namespace WeeklyTask_API.Controllers
{
    public class OrderController : Controller
    {

        Order_Service Call_Func = new Order_Service();

        // GET: Order

        [Route("Order/GetAllOrders")]
        [HttpGet]
        [ActionName("GetAllOrders")]
        public JsonResult Get()
        {
            var orders = Call_Func.GetAllOrders();
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }

        // GET : OrderByID

        [Route("Order/GetOrderByID/1")]
        [HttpGet]
        [ActionName("GetOrderByID")]
        public JsonResult Get(int ID)
        {
            var orders = Call_Func.GetOrderByID(ID);
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }
    }
}