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
    
    public partial class GymUser
    {
        public int Id { get; set; }
        public int GymId { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    
        public virtual Gym Gym { get; set; }
        public virtual User User { get; set; }
    }
}
