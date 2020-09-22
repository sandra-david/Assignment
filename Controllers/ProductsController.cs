using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WellBeingCampaign.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            //Models.Products products = new Models.Products();
            var data = Models.Products.GetProducts();

            return View(data.ToList());
        }

        [Route("products/{productName}")]
        public ActionResult Detail(string productName)
        {
            //lookup product name
            return View();
        }
    }
}