//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace m2ostnext
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_category_associantion
    {
        public int id_category_association { get; set; }
        public Nullable<int> id_category_tile { get; set; }
        public Nullable<int> id_category_heading { get; set; }
        public Nullable<int> id_category { get; set; }
        public Nullable<int> category_order { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> updated_date_time { get; set; }
    
        public virtual tbl_category tbl_category { get; set; }
        public virtual tbl_category_tiles tbl_category_tiles { get; set; }
        public virtual tbl_category_heading tbl_category_heading { get; set; }
    }
}
