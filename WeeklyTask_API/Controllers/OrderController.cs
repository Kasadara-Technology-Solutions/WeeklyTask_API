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

        // GET : OrderByName

        [Route("Order/GetOrderByCustomerID/1")]
        [HttpGet]
        [ActionName("GetOrderByCustomerID")]
        public JsonResult GetOrderByCustomerID(int ID)
        {
            var orders = Call_Func.GetOrderByCustomerID(ID);
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);

        }

        // GET : ListOrdersBySalesRepEmployeeNum

        [Route("Order/ListOrdersBySalesRepEmployeeNum/1")]
        [HttpGet]
        [ActionName("ListOrdersBySalesRepEmployeeNum")]
        public JsonResult ListOrdersBySalesRepEmployeeNum(int ID)
        {
            var orders = Call_Func.ListOrdersBySalesRepEmployeeNum(ID);
            return Json(new { orders = orders }, JsonRequestBehavior.AllowGet);
        }

        // GET : GetProductsByOrderID

        [Route("Order/GetProductsByOrderID/2")]
        [HttpGet]
        [ActionName("GetProductsByOrderID")]
        public JsonResult GetProductsByOrderID(int ID)
        {
            var pro = Call_Func.GetProductsByOrderID(ID);
            return Json(new { pro = pro }, JsonRequestBehavior.AllowGet);
        }

        // GET : GetProductsByCustomerID

        [Route("Order/GetProductsByCustomerID/2")]
        [HttpGet]
        [ActionName("GetProductsByCustomerID")]
        public JsonResult GetProductsByCustomerID(int ID)
        {
            var pro = Call_Func.GetProductsByCustomerID(ID);
            return Json(new { pro = pro }, JsonRequestBehavior.AllowGet);
        }

        // GET : ListOrdersByOfficeSales

        [Route("Order/ListOrdersByOfficeSales/2")]
        [HttpGet]
        [ActionName("ListOrdersByOfficeSales")]
        public JsonResult ListOrdersByOfficeSales(int ID)
        {
            var pro = Call_Func.ListOrdersByOfficeSales(ID);
            return Json(new { pro = pro }, JsonRequestBehavior.AllowGet);
        }

    }
}