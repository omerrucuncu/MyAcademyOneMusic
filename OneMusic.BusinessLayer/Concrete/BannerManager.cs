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
    public class BannerManager : IBannerService
    {
        private readonly IBannerDal _bannerDal; // Data access layer for banner-related operations 

        public BannerManager(IBannerDal bannerDal) // Constructor that takes an IBannerDal instance and assigns it to the private field 
        {
            _bannerDal = bannerDal; // Assign the provided data access layer to the private field 
        }

        public void TDelete(int id) // Delete operation in CRUD operations
        {
            _bannerDal.Delete(id); // Call the Delete method of the data access layer to delete a banner by its ID
        }

        public List<Banner> TGetAll() // Read operation in CRUD operations 
        {
            return _bannerDal.GetAll(); // Call the GetAll method of the data access layer to retrieve all banners
        }

        public Banner TGetById(int id) // Get a single entity by its ID 
        {
            return _bannerDal.GetById(id); // Call the GetById method of the data access layer to retrieve a banner by its ID
        }

        public void TInsert(Banner entity) // Create operation in CRUD operations
        {
            _bannerDal.Insert(entity); // Call the Insert method of the data access layer to add a new banner
        }

        public void TUpdate(Banner entity) // Update operation in CRUD operations
        {
            _bannerDal.Update(entity); // Call the Update method of the data access layer to update an existing banner
        }
    }
}
