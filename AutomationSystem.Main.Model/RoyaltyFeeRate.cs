//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutomationSystem.Main.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoyaltyFeeRate
    {
        public long RoyaltyFeeRateId { get; set; }
        public AutomationSystem.Base.Contract.Enums.RoyaltyFeeRateTypeEnum RoyaltyFeeRateTypeId { get; set; }
        public AutomationSystem.Base.Contract.Enums.CurrencyEnum CurrencyId { get; set; }
        public decimal Rate { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual RoyaltyFeeRateType RoyaltyFeeRateType { get; set; }
    }
}