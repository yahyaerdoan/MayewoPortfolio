//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MayewoPortfolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public int ProjectId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }
        public string Description { get; set; }
    
        public virtual Category Category { get; set; }
    }
}