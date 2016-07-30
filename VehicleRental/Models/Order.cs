using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleRental.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Name { get; set; }
        public string IdentifyId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string AddressDeliver { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsActive { get; set; }
    }
}