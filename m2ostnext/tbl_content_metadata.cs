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
    
    public partial class tbl_content_metadata
    {
        public int ID_CONTENT_METADATA { get; set; }
        public string CONTENT_METADATA { get; set; }
        public int CONTENT_METADATA_COUNTER { get; set; }
        public int ID_CONTENT_ANSWER { get; set; }
        public string STATUS { get; set; }
        public System.DateTime UPDATEDTIME { get; set; }
    
        public virtual tbl_content_answer tbl_content_answer { get; set; }
    }
}
