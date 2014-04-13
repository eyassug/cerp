using System.Data.Entity;
using CERP.Models.HumanResources;

namespace CERP.Modules.HumanResources.EmailConsole.DataAccess
{
// ReSharper disable InconsistentNaming
    class CERPContext : DbContext
// ReSharper restore InconsistentNaming
    {
        public CERPContext()
            : base(Program.ConnectionString)
        {
        }

        public CERPContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<PaySlipQueue> PaySlipQueue { get; set; }
        public DbSet<WagePayment> WagePayments { get; set; }
        public DbSet<WagePaymentDetail> WagePaymentDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
