//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Dao
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookCopy
    {
        public int BookID { get; set; }
        public int TotalStock { get; set; }
        public int NumRented { get; set; }
    
        public virtual Book Book { get; set; }
    }
}