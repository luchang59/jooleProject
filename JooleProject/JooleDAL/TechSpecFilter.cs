//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JooleDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TechSpecFilter
    {
        public int Property_ID { get; set; }
        public int SubCategory_ID { get; set; }
        public Nullable<decimal> Min_Value { get; set; }
        public Nullable<decimal> Max_Value { get; set; }
    
        public virtual Property Property { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
