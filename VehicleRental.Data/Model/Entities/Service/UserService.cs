using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Data.Model.Entities.Service
{
    public interface IUserService
    {
        List<User> GetList();
        User CheckLogin(string username, string password);
    }

    public class UserService : IUserService
    {

        VehicleRentalEntities db = null;

        public UserService()
        {
            db = new VehicleRentalEntities();
        }

        public User CheckLogin(string username, string password)
        {
            return db.Users.Where(n => n.Username == username && n.Password == password).SingleOrDefault();
        }

        public List<User> GetList()
        {
            return db.Users.ToList();
        }
    }
}
