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
    
    public partial class ClassRegistrationInvitation
    {
        public long ClassRegistrationInvitationId { get; set; }
        public Nullable<long> ClassRegistrationId { get; set; }
        public long ClassId { get; set; }
        public AutomationSystem.Base.Contract.Enums.LanguageEnum LanguageId { get; set; }
        public string Email { get; set; }
        public string RequestCode { get; set; }
        public AutomationSystem.Base.Contract.Enums.RegistrationTypeEnum RegistrationTypeId { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
    
        public virtual RegistrationType RegistrationType { get; set; }
        public virtual ClassRegistration ClassRegistration { get; set; }
        public virtual Class Class { get; set; }
    }
}
