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
    
    public partial class CardOperation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CardOperation()
        {
            this.Amount = 0.00m;
        }
    
        public System.Guid Id { get; set; }
        public System.Guid CardId { get; set; }
        public System.Guid OperationTypeId { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public decimal Balance { get; set; }
    
        public virtual Card Card { get; set; }
        public virtual OperationType OperationType { get; set; }
    }
}
