using SkyWeb.DatVM.Mvc;
using SkyWeb.DatVM.Mvc.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VehicleRental.Data.Model.Entities.Service;

namespace WebService.Controllers
{
    public class UserAPIController : BaseController
    {
        // api/UserAPI/CheckLogin
        [HttpGet]
        public Object CheckLogin(string username, string password)
        {
            var userService = this.Service<IUserService>();
            return userService.CheckLogin(username, password);
        }
    }
}
