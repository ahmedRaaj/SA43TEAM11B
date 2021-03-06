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
    
    public partial class BorrowingDetail
    {
        public System.Guid BorrowingID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public System.DateTime BorrowDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public Nullable<System.DateTime> ActualReturnDate { get; set; }
        public string BorrowingStatus { get; set; }
        public string Remarks { get; set; }
        public Nullable<double> Fine { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
