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
    
    public partial class tbl_non_disclousure_clause_log
    {
        public int id_clause_log { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_org { get; set; }
        public string log_status { get; set; }
        public Nullable<System.DateTime> updated_date_time { get; set; }
    }
}
