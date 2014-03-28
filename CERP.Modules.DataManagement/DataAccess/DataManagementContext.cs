using System.Data.Entity;
using Apex.Common.Data;
using CERP.Models.Business;
using CERP.Models.Inventory;

namespace CERP.Modules.DataManagement.DataAccess
{
    class DataManagementContext : DbContext, IUnitOfWork
    {
        #region Constructors

        public DataManagementContext()
            : this(@"Data Source=.\SQLSERVER;Initial Catalog=CERP;Integrated Security=True;")
        {
        }

        public DataManagementContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        #endregion

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PartnerType> PartnerTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<TaxPayer> TaxPayers { get; set; }

        #region IUnitOfWork Implementation
        public void CommitChanges()
        {
            SaveChanges();
        }

        public void RollBack()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
