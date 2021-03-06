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
    
    public partial class SystemConfig
    {
        public int Id { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public int PasswordChange { get; set; }
        public string ImagesLocation { get; set; }
        public string DocumentsLocation { get; set; }
        public string ContactEmail { get; set; }
        public string FinancialEmail { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string PaymentUserCode { get; set; }
        public string PaymentAccount { get; set; }
        public string AppDownloadUrl { get; set; }
        public string PaymentMonitorPath { get; set; }
        public Nullable<int> PaymentMonitorDay { get; set; }
        public Nullable<System.TimeSpan> PaymentMonitorStart { get; set; }
        public Nullable<System.DateTime> LastPaymentMonitorRun { get; set; }
        public Nullable<int> LastPaymentMonitorCount { get; set; }
        public string PaymentsExportPath { get; set; }
        public string StatementFolder { get; set; }
        public string PaymentFolder { get; set; }
        public Nullable<decimal> DRDiscount { get; set; }
    }
}
