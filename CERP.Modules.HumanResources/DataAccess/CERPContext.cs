using System.Data.Entity;

namespace CERP.Modules.HumanResources.DataAccess
{
    class CERPContext : DbContext
    {
        public CERPContext()
            : base(HumanResourcesModule.ConnectionString)
        {
        }

        public DbSet<Models.HumanResources.Employee> Employees { get; set; }
        public DbSet<Models.HumanResources.Department> Departments { get; set; }
        public DbSet<Models.HumanResources.ExtendedEmployee> ExtendedEmployees { get; set; }
        public DbSet<Models.HumanResources.WagePayment> WagePayments { get; set; }
        public DbSet<Models.HumanResources.WagePaymentDetail> WagePaymentDetails { get; set; }
        public DbSet<Models.HumanResources.WagePaymentStatusHistory> WagePaymentStatusHistory { get; set; }
        public DbSet<Models.HumanResources.PaySlipQueue> PaySlipQueues { get; set; }
        public DbSet<Models.HumanResources.EmployeePayHistory> EmployeePayHistory { get; set; }
        public DbSet<Models.HumanResources.EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        
    }
}
