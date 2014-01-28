using System.Data.Entity;
using Apex.Common.Data;
using CERP.Models.Views;

namespace CERP.Modules.Security
{
    class SecurityDataContext : DbContext, IUnitOfWork
    {
        public SecurityDataContext()
            : base(SecurityModule.Settings.ConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SecurityDataContext>(null);
        }

        #region DbSets

        public DbSet<User> Users { get; set; }

        #endregion

        #region IUnitOfWork implementation

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
