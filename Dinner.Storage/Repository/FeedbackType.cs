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
    
    public partial class FeedbackType
    {
        public FeedbackType()
        {
            this.Feedbacks = new HashSet<Feedback>();
        }
    
        public short ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
