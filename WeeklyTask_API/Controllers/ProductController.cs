using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeeklyTask_API.Services;

namespace WeeklyTask_API.Controllers
{
    public class ProductController : Controller
    {
        Product_Services Call_Func = new Product_Services();

        // GET: GetAllProducts

        [Route("Product/GetAllProducts")]
        [HttpGet]
        [ActionName("GetAllProducts")]
        public JsonResult Get()
        {
            var products = Call_Func.GetAllProducts();
            return Json(new { products = products }, JsonRequestBehavior.AllowGet);
        }

        // GET : GetAllProductsByID

        [Route("Product/GetAllProductsByID/2")]
        [HttpGet]
        [ActionName("GetAllProductsByID")]
        public JsonResult Get(int ID)
        {
            var products = Call_Func.GetAllProductsByID(ID);
            return Json(new { products = products }, JsonRequestBehavior.AllowGet);
        }

        // GET : GetProductByName

        [Route("Product/GetAllProductsByName/?Name=Sandeep")]
        [HttpGet]
        [ActionName("GetProductByName")]
        public JsonResult Get(string Name)
        {
            var product = Call_Func.GetProductByName(Name);
            return Json(new { products = product }, JsonRequestBehavior.AllowGet);
        }

    }
}