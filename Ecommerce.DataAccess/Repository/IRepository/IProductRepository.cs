using EcommerceBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBook.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product> 
    {
        void Update(Product obj); 
    }
}
