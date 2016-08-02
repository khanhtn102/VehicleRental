using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VehicleRental.Data.Model.Entities.Service;

namespace WebService.Controllers
{
    public class UserAPIController : ApiController
    {
        private IUserService Service = null;

        public UserAPIController()
        {
            this.Service = new UserService();
        }

        // api/UserAPI/CheckLogin
        [HttpGet]
        public Object CheckLogin(string username, string password)
        {
            return Service.CheckLogin(username, password);
        }
    }
}
