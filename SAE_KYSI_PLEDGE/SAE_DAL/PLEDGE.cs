//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAE_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLEDGE
    {
        public PLEDGE()
        {
            this.FACTs = new HashSet<FACT>();
        }
    
        public int PLEDGE_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string STREET_ADDR { get; set; }
        public string CITY { get; set; }
        public string ZIP { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> GRAD_YEAR { get; set; }
        public string BIG_BROTHER_FIRST { get; set; }
        public string BIG_BROTHER_LAST { get; set; }
    
        public virtual ICollection<FACT> FACTs { get; set; }
    }
}
