using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Data.Model.Entities.Service
{
    public partial interface IUserService
    {
        User CheckLogin(string username, string password);
    }

    public partial class UserService
    {
        public User CheckLogin(string username, string password)
        {
            var user = this.Get().Where(n => n.Username == username && n.Password == password).FirstOrDefault();
            return user;
        }
    }
}
