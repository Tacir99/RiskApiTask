using Data.Connection;
using Data.DAL;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository:GenericRepository<Product>,IProductDAL
    {
        private readonly DbConnection _db;

        public ProductRepository(Connection.DbConnection context) : base(context)
        {
            _db = context;
        }

       
    }
}
