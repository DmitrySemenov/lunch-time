//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dinner.Storage.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuItemWish
    {
        public int ID { get; set; }
        public int CustomerUserID { get; set; }
        public int MenuItemID { get; set; }
        public System.DateTime Date { get; set; }
        public int CourseCategoryID { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual User User { get; set; }
        public virtual CourseCategory CourseCategory { get; set; }
    }
}