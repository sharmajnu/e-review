using ER.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ER.DataLayer.RepositoryInterfaces;
using System.Linq.Expressions;

namespace ER.DataLayer.RepositoryInterfaces
{
    public interface IProductRepository : IEntityRepository<Product>
    {
    }
}
