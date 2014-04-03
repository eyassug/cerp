using Apex.Common.Data;
using CERP.Modules.DataManagement.DataAccess;
using CERP.Models.Inventory;

namespace CERP.Modules.DataManagement.Repository
{
    class ProductRepository : EntityFrameworkRepository<DataManagementContext,Product>
    {
        public ProductRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
