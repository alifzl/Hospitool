//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospitool
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PaymentID { get; set; }
        public string PaymentName { get; set; }
        public string PaymentSurname { get; set; }
        public string PaymentCredircard { get; set; }
        public string PaymentCVV { get; set; }
        public string PaymentExpiration { get; set; }
        public decimal PaymentCost { get; set; }
        public int PatientID { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
