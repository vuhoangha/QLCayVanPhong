//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhoaLuan.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account()
        {
            this.Bills = new HashSet<Bill>();
            this.Imports = new HashSet<Import>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string BirthDay { get; set; }
        public string Address { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Import> Imports { get; set; }
    }
}
