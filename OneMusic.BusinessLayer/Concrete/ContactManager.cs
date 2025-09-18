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
    public class ContactManager : IContactService // Implementation of contact-related operations  inheriting from IContactService 
    {
        private readonly IContactDal _contactDal; // Dependency on the data access layer for contact entities 

        public ContactManager(IContactDal contactDal) // Constructor that takes an IContactDal and assigns it to the private field 
        {
            _contactDal = contactDal; // Assign the provided data access layer to the private field 
        }

        public void TDelete(int id) // Delete operation in CRUD operations 
        { 
            _contactDal.Delete(id); // Call the Delete method of the data access layer to delete a contact by its ID
        }

        public List<Contact> TGetAll() // Read operation in CRUD operations
        {
            return _contactDal.GetAll(); // Call the GetAll method of the data access layer to retrieve all contacts
        }

        public Contact TGetById(int id) // Get a single contact by its ID
        {
            return _contactDal.GetById(id); // Call the GetById method of the data access layer to retrieve a contact by its ID
        }
        

        public void TInsert(Contact entity) // Create operation in CRUD operations 
        {
            _contactDal.Insert(entity); // Call the Insert method of the data access layer to add a new contact
        }

        public void TUpdate(Contact entity) // Update operation in CRUD operations 
        { 
            _contactDal.Update(entity); // Call the Update method of the data access layer to update an existing contact
        }
    }
}
