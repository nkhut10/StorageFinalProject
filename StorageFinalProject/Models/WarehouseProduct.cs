//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorageFinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WarehouseProduct
    {
        public int ID { get; set; }
        public int WarehouseID { get; set; }
        public int CategoryID { get; set; }
        public int ProductTypeID { get; set; }
        public int Quantity { get; set; }
    }
}
