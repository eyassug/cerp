using System.Data.Entity;
using Apex.Common.Data;
using CERP.Models.Security;

namespace CERP.Modules.Security.DataAccess
{
    class SecurityDataContext : DbContext, IUnitOfWork
    {
        public SecurityDataContext()
            : this(@"Data Source=Yesammy-pc;Initial Catalog=CERP;Integrated Security=True;")
        {
        }
        public SecurityDataContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SecurityDataContext>(null);
        }

        #region DbSets

        public DbSet<UserAccount> Users { get; set; }

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
