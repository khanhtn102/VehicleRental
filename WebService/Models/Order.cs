//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Name { get; set; }
        public string IdentifyId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string AddressDeliver { get; set; }
        public Nullable<System.DateTime> RentDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Vehicle Vehicle { get; set; }
    }
}