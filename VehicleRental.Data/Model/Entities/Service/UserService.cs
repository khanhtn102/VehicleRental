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
        //List<User> GetList();
        //User CheckLogin(string username, string password);
        IQueryable<User> CheckLogin(string username, string password);
    }

    public partial class UserService
    {

        //VehicleRentalEntities db = null;
        public object ICultureInfo { get; private set; }

        public IQueryable<User> CheckLogin(string username, string password)
        {
            var user = this.Get().Where(n => n.Username == username && n.Password == password);
            return user;
        }
        //public UserService()
        //{
        //    db = new VehicleRentalEntities();
        //}

        //public User CheckLogin(string username, string password)
        //{
        //    return db.Users.Where(n => n.Username == username && n.Password == password).SingleOrDefault();
        //}

        //public List<User> GetList()
        //{
        //    return db.Users.ToList();
        //}
    }
}
