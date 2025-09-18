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
    public class MessageManager : IMessageService // Implementation of the IMessageService interface  
    {
        private readonly IMessageDal _messageDal; // Data access layer for message-related operations 

        public MessageManager(IMessageDal messageDal) // Constructor that takes an IMessageDal instance for dependency injection 
        {
            _messageDal = messageDal; // Assign the injected IMessageDal instance to the private field 
        }

        public void TDelete(int id) // Delete operation in CRUD operations
        {
            _messageDal.Delete(id); // Call the Delete method of the data access layer to delete a message by its ID
        }

        public List<Message> TGetAll() // Read operation in CRUD operations 
        {
            return _messageDal.GetAll(); // Call the GetAll method of the data access layer to retrieve all messages
        }

        public Message TGetById(int id) // Get a single entity by its ID 
        {
            return _messageDal.GetById(id); // Call the GetById method of the data access layer to retrieve a message by its ID
        }
      

        public void TInsert(Message entity) // Create operation in CRUD operations
        {
            _messageDal.Insert(entity); // Call the Insert method of the data access layer to add a new message 
        }

        public void TUpdate(Message entity) // Update operation in CRUD operations
        {
            _messageDal.Update(entity); // Call the Update method of the data access layer to update an existing message
        }
    }
}
