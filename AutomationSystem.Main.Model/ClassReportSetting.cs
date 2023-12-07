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
    
    public partial class ClassReportSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassReportSetting()
        {
            this.Classes = new HashSet<Class>();
        }
    
        public long ClassReportSettingId { get; set; }
        public string VenueName { get; set; }
        public string LocationCode { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public bool Deleted { get; set; }
        public Nullable<long> LocationInfoId { get; set; }
    
        public virtual Person LocationInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
    }
}