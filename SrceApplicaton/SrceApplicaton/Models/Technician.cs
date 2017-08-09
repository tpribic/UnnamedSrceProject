//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SrceApplicaton.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Technician
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Technician()
        {
            this.Job = new HashSet<Job>();
        }
    
        public short TechnicianID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> DateHired { get; set; }
        public string Color { get; set; }
        public string email { get; set; }
        public string Username { get; set; }
        public string AccessLevel { get; set; }
        public string Password { get; set; }
        public Nullable<byte> WorkHours { get; set; }
        public Nullable<byte> ThisMonthSalary { get; set; }
        public Nullable<byte> ThisYearSalary { get; set; }
        public Nullable<byte> LastMonthSalary { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Job { get; set; }
    }
}
