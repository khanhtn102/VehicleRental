//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleRental.Data.Model.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<VehicleRental.Data.Model.Entities.Vehicle>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual int UserId { get; set; }
    			public virtual Nullable<int> BrandId { get; set; }
    			public virtual Nullable<int> TypeId { get; set; }
    			public virtual string VehicleName { get; set; }
    			public virtual string Description { get; set; }
    			public virtual Nullable<decimal> ReantalPrice { get; set; }
    			public virtual Nullable<System.DateTime> StartDate { get; set; }
    			public virtual Nullable<System.DateTime> EndDate { get; set; }
    			public virtual string ContractFileUrl { get; set; }
    			public virtual Nullable<bool> IsActive { get; set; }
    	
    	public VehicleViewModel() : base() { }
    	public VehicleViewModel(VehicleRental.Data.Model.Entities.Vehicle entity) : base(entity) { }
    
    }
}