using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Borrower
    {
        [Key]
        [Required]
        public int  borrower_id{ get; set; }
        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
        public string borrower_name { get; set; }

        public string City { get; set; }
        public string state { get; set; }
        public string country{ get; set; }
        public int street { get; set; }
        public string companyname { get; set; }
        public string jobname { get; set; }
        //public int LoanID { get; set; }

        //1 Student---M Enrollments

        public virtual ICollection<Loan> BLoans { get; set; }
       // public virtual Loan Details { get; set; }

    }

    public class Loan
    {
        [Key]
        public int LoanID { get; set; }

        public string Loantype { get; set; }

       
        public int Amount { get; set; }
        public int duration { get; set; }
        public double RateInterest  { get; set; }

        

    }


    public class MyContext2 : DbContext
    {
        public MyContext2() : base("MyContext2")
        {
            //createdatabase if not exists
            //drop create always
            //drop create if model changes

            Database.SetInitializer<MyContext2>(new CreateDatabaseIfNotExists<MyContext2>());
        }

        public virtual DbSet<Borrower> BTable { get; set; }
        public virtual DbSet<Loan> LoanTable { get; set; }
        

    }
    
}
