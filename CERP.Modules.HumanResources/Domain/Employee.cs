using System;
using System.ComponentModel.DataAnnotations;
using CERP.Models.HumanResources;

namespace CERP.Modules.HumanResources.Domain
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public PaymentFrequency PaymentFrequency { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }

    }
}
