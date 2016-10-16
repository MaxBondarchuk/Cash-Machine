//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cash_Machine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Card()
        {
            this.IsBlocked = false;
            this.Balance = 0.00m;
            this.CardOperation = new HashSet<CardOperation>();
        }
    
        public System.Guid Id { get; set; }
        public bool IsBlocked { get; set; }
        public decimal Balance { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardOperation> CardOperation { get; set; }
    }
}
