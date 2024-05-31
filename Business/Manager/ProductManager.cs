using Business.Service;
using Data.DAL;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class ProductManager:IProductService
    {
        private readonly IProductDAL _dal;
        public ProductManager(IProductDAL dal)
        {
            _dal = dal;
        }

        
        public void Create(Product entity)
        {
            _dal.Create(entity);
        }

       
        public void Delete(Product entity)
        {
            _dal.Delete(entity);
        }

        public Product GetById(int id)
        {
            return _dal.GetById(id);
        }

        public IEnumerable<Product> GetList()
        {
            return _dal.GetList();
        }

                
        public void Update(Product entity)
        {
            _dal.Update(entity);
        }
    }
}
