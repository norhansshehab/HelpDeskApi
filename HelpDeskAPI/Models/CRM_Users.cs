//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDeskAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CRM_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRM_Users()
        {
            this.TSS_Clients = new HashSet<TSS_Clients>();
        }
    
        public long UsersID { get; set; }
        public string ShortName { get; set; }
        public string UsersFullName { get; set; }
        public System.Guid UsersGUID { get; set; }
        public string UsersUserName { get; set; }
        public string UsersPassword { get; set; }
        public string UsersEmail { get; set; }
        public string UsersMobile { get; set; }
        public string UsersPhone { get; set; }
        public string UsersPhoneExt { get; set; }
        public Nullable<bool> UsersIsAdmin { get; set; }
        public Nullable<bool> UsersActive { get; set; }
        public Nullable<bool> SendEmail { get; set; }
        public Nullable<bool> SendSMS { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<long> CreatedByID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<long> UpdatedByID { get; set; }
        public int UpdatedCounts { get; set; }
        public Nullable<System.DateTime> Deleted { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<long> DeletedByID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSS_Clients> TSS_Clients { get; set; }
    }
}
