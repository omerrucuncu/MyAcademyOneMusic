using OneMusic.DataAccessLayer.Abstract;
using OneMusic.DataAccessLayer.Context;
using OneMusic.DataAccessLayer.Repositories;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Concrete // Concrete implementation of data access layer for About entity 
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal // Entity Framework implementation of IAboutDal for About entity 
    {
        public EFAboutDal(OneMusicContext context) : base(context) // Constructor to initialize the database context in the base class
        {
        }
    }
}
