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
    
    public partial class Category
    {
        public Category()
        {
            this.Trees = new HashSet<Tree>();
        }
    
        public int CatId { get; set; }
        public string CatName { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ICollection<Tree> Trees { get; set; }
    }
}
