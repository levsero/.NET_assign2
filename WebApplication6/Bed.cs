//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bed
    {
        public Bed()
        {
            this.visit = new HashSet<visit>();
        }
    
        public int Id { get; set; }
        public string Bedtype { get; set; }
        public decimal RatePerDay { get; set; }
    
        public virtual ICollection<visit> visit { get; set; }
    }
}
