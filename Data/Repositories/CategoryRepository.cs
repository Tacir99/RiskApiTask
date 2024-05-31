using Data.DAL;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.Connection;

namespace Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
        private readonly DbConnection _db;
       
        public CategoryRepository(Connection.DbConnection context) : base(context)
        {
            _db=context;
        }

        

    }
}
