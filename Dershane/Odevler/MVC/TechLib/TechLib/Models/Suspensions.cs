//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechLib.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suspensions
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public System.DateTime SuspensionStartDate { get; set; }
        public System.DateTime SuspensionEndDate { get; set; }
        public string Reason { get; set; }
    
        public virtual Students Students { get; set; }
    }
}