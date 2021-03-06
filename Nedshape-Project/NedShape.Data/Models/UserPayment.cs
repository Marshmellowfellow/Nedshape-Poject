//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NedShape.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPayment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GymServiceId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string PaymentReference { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual GymService GymService { get; set; }
        public virtual User User { get; set; }
    }
}
