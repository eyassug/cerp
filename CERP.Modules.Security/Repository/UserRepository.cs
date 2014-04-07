using Apex.Common.Data;
using CERP.Models.Security;
using CERP.Modules.Security.DataAccess;

namespace CERP.Modules.Security.Repository
{
    class UserRepository : EntityFrameworkRepository<SecurityDataContext,UserAccount>
    {
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

       
    }
}
