using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using VehicleRental.Models;
using VehicleRental.StringResource;

namespace VehicleRental.Controllers
{
    public class OrderController : Controller
    {

        HttpClient client = new HttpClient();

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // Get List Order
        public ActionResult GetList()
        {
            List<Order> list = new List<Order>();

            client.BaseAddress = new Uri(Configuration.URL_SERVICE);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Configuration.APP_JSON));

            HttpResponseMessage response = client.GetAsync(Configuration.API_ORDER).Result;
            if (response.IsSuccessStatusCode)
            {
                list = response.Content.ReadAsAsync<List<Order>>().Result;
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}