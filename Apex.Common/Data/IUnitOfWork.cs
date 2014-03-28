using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Common.Data
{
    public interface IUnitOfWork
    {
        void CommitChanges();
        void RollBack();
    }
}
