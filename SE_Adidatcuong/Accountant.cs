//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SE_Adidatcuong
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accountant
    {
        public Accountant()
        {
            this.AccountantInfoes = new HashSet<AccountantInfo>();
        }
    
        public int ID { get; set; }
        public string AccountantID { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<AccountantInfo> AccountantInfoes { get; set; }
    }
}