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
    
    public partial class p_GetDayMenu_Result
    {
        public int MenuID { get; set; }
        public int CourseID { get; set; }
        public int CompanyID { get; set; }
        public int CourseCategoryID { get; set; }
        public string CourseCategoryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public System.DateTime Date { get; set; }
        public int Limit { get; set; }
        public string Weight { get; set; }
        public Nullable<decimal> OrderedQuantity { get; set; }
    }
}