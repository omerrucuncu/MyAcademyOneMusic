using OneMusic.DataAccessLayer.Abstract;
using OneMusic.DataAccessLayer.Context;
using OneMusic.DataAccessLayer.Repositories;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Concrete
{
    public class EFContactDal : GenericRepository<Contact>, IContactDal // Concrete implementation of IContactDal using Entity Framework 
    {
        public EFContactDal(OneMusicContext context) : base(context) // Constructor that takes a OneMusicContext and passes it to the base class constructor
        {
        }
    }
}
