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
    public class AlbumManager : IAlbumService
    {
        private readonly IAlbumDal _albumDal; // Data access layer for album-related operations 
        public AlbumManager(IAlbumDal albumDal) // Constructor that takes an IAlbumDal instance as a dependency
        {
            _albumDal = albumDal; // Initialize the data access layer field 
        }
        public void TDelete(int id) // Delete operation in CRUD operations 
        {
            _albumDal.Delete(id); // Call the Delete method of the data access layer to delete an album by its ID 
        }

        public List<Album> TGetAll() // Read operation in CRUD operations 
        {
            return _albumDal.GetAll(); // Call the GetAll method of the data access layer to retrieve all albums
        }

        public Album TGetById(int id) // Get a single entity by its ID 
        {
            return _albumDal.GetById(id); // Call the GetById method of the data access layer to retrieve an album by its ID
        }

        public void TInsert(Album entity) // Create operation in CRUD operations
        {
            _albumDal.Insert(entity); // Call the Insert method of the data access layer to add a new album
        }

        public void TUpdate(Album entity) // Update operation in CRUD operations
        {
            _albumDal.Update(entity); // Call the Update method of the data access layer to update an existing album
        }
    }
}
