using OneMusic.BusinessLayer.Abstract;
using OneMusic.DataAccessLayer.Abstract;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Concrete
{
    public class SingerManager : ISingerService
    {
        private readonly ISingerDal _singerDal; // Data access layer for singer entities 

        public SingerManager(ISingerDal singerDal) // Constructor that takes an ISingerDal and assigns it to the private field 
        {
            _singerDal = singerDal; // Assign the provided ISingerDal to the private field 
        }

        public void TDelete(int id) // Delete operation in CRUD operations
        {
            _singerDal.Delete(id); // Call the Delete method of the data access layer to delete a singer by ID
        }

        public List<Singer> TGetAll() // Read operation in CRUD operations
        {
            return _singerDal.GetAll(); // Call the GetAll method of the data access layer to retrieve all singers
        }

        public Singer TGetById(int id) // Get a single entity by its ID
        {
            return _singerDal.GetById(id); // Call the GetById method of the data access layer to retrieve a singer by ID
        }

        public void TInsert(Singer entity) // Create operation in CRUD operations
        {
            _singerDal.Insert(entity); // Call the Insert method of the data access layer to add a new singer
        }

        public void TUpdate(Singer entity) // Update operation in CRUD operations
        {
            _singerDal.Update(entity); // Call the Update method of the data access layer to update an existing singer
        }
    }
}
