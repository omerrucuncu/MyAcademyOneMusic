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
            _context = context; // Assign the provided context to the private field 
        }
        public void Delete(int id) // Delete operation in CRUD operations 
        {
            var entity = _context.Set<T>().Find(id); // Find the entity with the specified ID
            if (entity != null) // If the entity exists
            {
                _context.Remove(entity); // Remove the entity from the database context
                _context.SaveChanges(); // Save changes to the database
            }
        }

        public List<T> GetAll() // Read operation in CRUD operations
        {
            return _context.Set<T>().ToList(); // Retrieve all entities of type T from the database
        }

        public T GetById(int id) // Get a single entity by its ID
        {
            return _context.Set<T>().Find(id); // Find and return the entity with the specified ID
        }

        public void Insert(T entity) // Create operation in CRUD operations
        {
            _context.Add(entity); // Add the new entity to the database context
            _context.SaveChanges(); // Save changes to the database
        }

        public void Update(T entity) // Update operation in CRUD operations
        {
            _context.Update(entity); // Update the existing entity in the database context
        }
    }
}
