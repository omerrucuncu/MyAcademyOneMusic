using OneMusic.DataAccessLayer.Abstract;
using OneMusic.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class // Generic repository implementation for CRUD operations 
    {
        private readonly OneMusicContext _context; // Database context for data access 
        public GenericRepository(OneMusicContext context) // Constructor to initialize the database context 
        {
            _context = context;
        }
        public void Delete(int id) // Delete operation in CRUD operations 
        {
            throw new NotImplementedException(); 
        }

        public List<T> GetAll() // Read operation in CRUD operations
        {
            throw new NotImplementedException();
        }

        public T GetById(int id) // Get a single entity by its ID
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity) // Create operation in CRUD operations
        {
            throw new NotImplementedException();
        }

        public void Update(T entity) // Update operation in CRUD operations
        {
            throw new NotImplementedException();
        }
    }
}
