//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JadeAndrewIsit420HW4
{
    using System;
    using System.Collections.Generic;
    
    public partial class CDTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CDTable()
        {
            this.Inventories = new HashSet<Inventory>();
            this.Orders = new HashSet<Order>();
        }
    
        public int cdID { get; set; }
        public string CDname { get; set; }
        public string Artist { get; set; }
        public string RecordCompany { get; set; }
        public int YearReleased { get; set; }
        public decimal ListPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
