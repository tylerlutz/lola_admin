//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeyondThemes.BeyondAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event_Registration
    {
        public int Event_Registration_ID { get; set; }
        public string Id { get; set; }
        public Nullable<int> Event_ID { get; set; }
        public Nullable<System.DateTime> Event_Date { get; set; }
        public string Transaction_ID { get; set; }
        public string P_Name { get; set; }
        public string P_Phone { get; set; }
        public Nullable<bool> P_UnderAge { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
