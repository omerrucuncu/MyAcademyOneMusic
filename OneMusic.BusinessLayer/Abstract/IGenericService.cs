using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class // Generic service interface for CRUD operations
    {
        void TInsert(T entity); // Create operation in CRUD  operations 
        void TUpdate(T entity); // Update operation in CRUD operations
        void TDelete(int id); // Delete operation in CRUD operations 
        List<T> TGetAll(); // Read operation in CRUD operations 
        T TGetById(int id); // Get a single entity by its ID 
    }
}
