//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cash_Machine.Views.Home
{
    using System;
    using System.Collections.Generic;
    
    public partial class CardOperation
    {
        public System.Guid Id { get; set; }
        public System.Guid CardId { get; set; }
        public System.Guid OperationTypeId { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Card Card { get; set; }
        public virtual OperationType OperationType { get; set; }
    }
}
