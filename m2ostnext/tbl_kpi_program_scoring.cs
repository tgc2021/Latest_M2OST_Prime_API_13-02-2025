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
    
    public partial class tbl_kpi_program_scoring
    {
        public int id_kpi_program_scoring { get; set; }
        public Nullable<int> id_organization { get; set; }
        public Nullable<int> kpi_type { get; set; }
        public Nullable<int> id_category { get; set; }
        public Nullable<int> id_assessment { get; set; }
        public Nullable<int> id_kpi_master { get; set; }
        public Nullable<double> ps_weightage { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> updated_date_time { get; set; }
    }
}
