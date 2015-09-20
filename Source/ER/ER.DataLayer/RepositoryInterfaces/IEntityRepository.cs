using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ER.DataLayer.RepositoryInterfaces
{
    public interface IEntityRepository<T>
    {
        IEnumerable<T> All { get; }
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(int id);
        void InsertOrUpdate(T T);
        void Delete(int id);
    }
}
