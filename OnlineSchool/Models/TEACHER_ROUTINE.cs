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
    
    public partial class TEACHER_ROUTINE
    {
        public int TeacherRoutine_ID { get; set; }
        public string TeacherRoutineDirectory { get; set; }
        public int Teacher_ID { get; set; }
        public int Admin_ID { get; set; }
    
        public virtual ADMIN ADMIN { get; set; }
        public virtual TEACHER TEACHER { get; set; }
    }
}