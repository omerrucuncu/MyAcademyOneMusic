using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // Generic repository interface for CRUD operations 
    {
        void Insert(T entity); // Create operation in CRUD  operations 
        void Update(T entity); // Update operation in CRUD operations
        void Delete(int id); // Delete operation in CRUD operations 
        List<T> GetAll(); // Read operation in CRUD operations 
        T GetById(int id); // Get a single entity by its ID 
    }
}
