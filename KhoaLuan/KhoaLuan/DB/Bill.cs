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
    
    public partial class Bill
    {
        public Bill()
        {
            this.BillDetails = new HashSet<BillDetail>();
        }
    
        public int BillId { get; set; }
        public Nullable<System.DateTime> TimeChanged { get; set; }
        public Nullable<int> TotalCost { get; set; }
        public Nullable<int> UserId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
