//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hi_Tech_Library.BLL.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookOrder
    {
        public int BookOrderId { get; set; }
        public string ISBN { get; set; }
        public int OrderId { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}