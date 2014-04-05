using System.Collections.Generic;

namespace Apex.Common.Caching
{
    interface ICachedRepository<TType, TKeyType> where TType : class,ICacheable, new() where TKeyType : class 
    {
        TType FindSingle(TKeyType key);
        ICollection<TType> FindAll();
    }
}
