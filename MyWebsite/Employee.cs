//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebsite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string SSN { get; set; }
        public decimal Salary { get; set; }
        public decimal PriorSalary { get; set; }
        public Nullable<decimal> LastRaise { get; set; }
        public System.DateTime HireDate { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public int ManagerEmpID { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
