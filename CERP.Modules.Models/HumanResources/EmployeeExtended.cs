using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("vEmployee", Schema = "HumanResources")]
    public class EmployeeExtended
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        [Column("BirthDate")]
        public DateTime DateOfBirth { get; set; }

        [Column("Gender"), Required(AllowEmptyStrings = false), MaxLength(1)]
        public string GenderCode { get; set; }

        [NotMapped]
        public Gender Gender
        {
            get { return GenderCode == "F" ? Gender.Female : Gender.Male; }
            set { GenderCode = (value == Gender.Female ? "F" :  "M"); }
        }

        [Column("MaritalStatus"), Required(AllowEmptyStrings = false),MaxLength(1)]
        public string MaritalStatusCode { get; set; }

        [NotMapped]
        public MaritalStatus? Status
        {
            get { return MaritalStatusCode == "M" ? MaritalStatus.Married : MaritalStatus.Single; }
            set { var s = value == MaritalStatus.Married ? MaritalStatusCode = "M" : MaritalStatusCode = "S"; }
        }

        [Column("CurrentFlag")]
        public bool IsCurrent { get; set; }
        [Column("HireDate")]
        public DateTime DateOfHire { get; set; }

        public int DepartmentID { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public Guid? Rowguid { get; set; }

        [NotMapped]
        public PaymentFrequency PaymentFrequency
        {
            get { return (PaymentFrequency) PayFrequency; }
            set { PayFrequency = (byte) value; }
        }
    }
}
