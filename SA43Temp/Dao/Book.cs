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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BorrowingDetails = new HashSet<BorrowingDetail>();
        }
    
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int CategoryID { get; set; }
        public int PublisherID { get; set; }
        public string Authors { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string ISBN { get; set; }
        public string LocationDetails { get; set; }
    
        public virtual BookCopy BookCopy { get; set; }
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowingDetail> BorrowingDetails { get; set; }
        public override string ToString()
        {
            return this.BookName;
        }
    }
}
