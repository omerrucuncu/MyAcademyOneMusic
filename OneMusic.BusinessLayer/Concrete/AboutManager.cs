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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal; // Data access layer for About entity 

        public AboutManager(IAboutDal aboutDal) // Constructor to inject the data access layer dependency
        {
            _aboutDal = aboutDal; // Assign the injected data access layer to the private field 
        }

        public void TDelete(int id)
        {
            _aboutDal.Delete(id); // Call the Delete method of the data access layer to remove an About entity by its ID
        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetAll(); // Call the GetAll method of the data access layer to retrieve all About entities
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id); // Call the GetById method of the data access layer to retrieve an About entity by its ID
        }

        public void TInsert(About entity) // Create operation in CRUD operations 
        {
            _aboutDal.Insert(entity); // Call the Insert method of the data access layer to add a new About entity
        }

        public void TUpdate(About entity) // Update operation in CRUD operations
        {
            _aboutDal.Update(entity); // Call the Update method of the data access layer to update an existing About entity
        }
    }
}
