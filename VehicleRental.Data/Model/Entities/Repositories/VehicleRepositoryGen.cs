//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleRental.Data.Model.Entities.Repositories
{
    using System;
    using System.Collections.Generic;
    
    
    public partial interface IVehicleRepository : SkyWeb.DatVM.Data.IBaseRepository<Vehicle>
    {
    }
    
    public partial class VehicleRepository : SkyWeb.DatVM.Data.BaseRepository<Vehicle>, IVehicleRepository
    {
    	public VehicleRepository(System.Data.Entity.DbContext dbContext) : base(dbContext)
        {
        }
    }
}
