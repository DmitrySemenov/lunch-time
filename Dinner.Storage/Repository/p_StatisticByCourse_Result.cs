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
    
    public partial class p_StatisticByCourse_Result
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Nullable<int> CourseCount { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public string CategoryName { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> DayCount { get; set; }
    }
}