//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loan
    {
        public int LoanId { get; set; }
        public string Loantype { get; set; }
        public string Amount { get; set; }
        public string Duration { get; set; }
        public string Rate_of_Interest { get; set; }
        public int BorrowerBorrowerId { get; set; }
    
        public virtual Borrower Borrower { get; set; }
    }
}