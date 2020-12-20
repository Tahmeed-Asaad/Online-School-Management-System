//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineSchool.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    public partial class TEACHER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEACHER()
        {
            this.ATTENDANCEs = new HashSet<ATTENDANCE>();
            this.RESULTs = new HashSet<RESULT>();
            this.SUBJECTs = new HashSet<SUBJECT>();
            this.TEACHER_ROUTINE = new HashSet<TEACHER_ROUTINE>();
        }
    
        public int Teacher_ID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        [DataType(DataType.Password)]
        public string TeacherPassword { get; set; }
        public string TeacherContactNumber { get; set; }
        public string TeacherAddress { get; set; }
        public int Admin_ID { get; set; }
    
        public virtual ADMIN ADMIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDANCE> ATTENDANCEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULT> RESULTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBJECT> SUBJECTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEACHER_ROUTINE> TEACHER_ROUTINE { get; set; }
    }
}
