//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppRentCompany.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rent
    {
        public int Id_rent { get; set; }
        public Nullable<int> Id_vehicle { get; set; }
        public Nullable<int> Id_driver { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> Id_insurance { get; set; }
    }
}
