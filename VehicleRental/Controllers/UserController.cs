using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleRental.Data.Model.Entities.Service;

namespace VehicleRental.Controllers
{
    public class UserController : Controller
    {

        private IUserService Service = null;
        
        public UserController()
        {
            this.Service = new UserService();
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetListUser()
        {
            return Json(Service.GetList(), JsonRequestBehavior.AllowGet);
        }
    }
}