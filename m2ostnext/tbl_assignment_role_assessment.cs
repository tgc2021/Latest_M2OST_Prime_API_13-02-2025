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
    
    public partial class tbl_assignment_role_assessment
    {
        public int id_assignment_role_assessment { get; set; }
        public Nullable<int> id_organization { get; set; }
        public Nullable<int> id_role { get; set; }
        public Nullable<int> id_assessment { get; set; }
        public Nullable<System.DateTime> start_datetime { get; set; }
        public Nullable<System.DateTime> end_datetime { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> updated_date_time { get; set; }
    }
}
