//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcResumePage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SocialMediaInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SocialMedia { get; set; }
        public string SocialMediaLink { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
