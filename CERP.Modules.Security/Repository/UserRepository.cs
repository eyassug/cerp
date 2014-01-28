using Apex.Common.Data;
using CERP.Models.Views;

namespace CERP.Modules.Security.Repository
{
    class UserRepository : EntityFrameworkRepository<SecurityDataContext,User>
    {
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
