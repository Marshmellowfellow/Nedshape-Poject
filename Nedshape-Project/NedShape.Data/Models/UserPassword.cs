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
    
    public partial class UserPassword
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string Password { get; set; }
        public System.DateTime PasswordDate { get; set; }
        public int Status { get; set; }
    
        public virtual User User { get; set; }
    }
}
