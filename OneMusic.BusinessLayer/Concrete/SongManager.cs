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
    public class SongManager : ISongService // Concrete implementation of ISongService for managing song-related operations 
    {
        private readonly ISongDal _songDal; // Data access layer interface for song-related database operations 
        public SongManager(ISongDal songDal) // Constructor that takes an ISongDal implementation as a dependency 
        {
            _songDal = songDal; // Assign the injected ISongDal implementation to the private field
        }
        public void TDelete(int id) // Delete operation in CRUD operations
        {
            _songDal.Delete(id); // Call the Delete method of the data access layer to delete a song by its ID
        }

        public List<Song> TGetAll() // Read operation in CRUD operations
        {
            return _songDal.GetAll(); // Call the GetAll method of the data access layer to retrieve all songs
        }

        public Song TGetById(int id) // Get a single entity by its ID
        {
            return _songDal.GetById(id); // Call the GetById method of the data access layer to retrieve a song by its ID
        }

        public void TInsert(Song entity) // Create operation in CRUD operations
        {
            _songDal.Insert(entity); // Call the Insert method of the data access layer to add a new song
        }

        public void TUpdate(Song entity) // Update operation in CRUD operations
        {
            _songDal.Update(entity); // Call the Update method of the data access layer to update an existing song
        }
    }
}
