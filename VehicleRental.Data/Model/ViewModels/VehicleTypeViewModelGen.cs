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
    
    public partial class VehicleTypeViewModel : SkyWeb.DatVM.Mvc.BaseEntityViewModel<VehicleRental.Data.Model.Entities.VehicleType>
    {
    	
    			public virtual int Id { get; set; }
    			public virtual string VehicleType1 { get; set; }
    	
    	public VehicleTypeViewModel() : base() { }
    	public VehicleTypeViewModel(VehicleRental.Data.Model.Entities.VehicleType entity) : base(entity) { }
    
    }
}