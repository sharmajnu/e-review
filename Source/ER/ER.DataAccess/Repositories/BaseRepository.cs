using ER.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.DataAccess
{
    public class BaseRepository
    {
        protected DataContext _Context;

        public BaseRepository(DataContext context)
        {
            _Context = context;
        }
    }
}
