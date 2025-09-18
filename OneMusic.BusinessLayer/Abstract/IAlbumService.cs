using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Abstract
{
    public interface IAlbumService : IGenericService<Album> // Interface for album-related operations inheriting from a generic service interface
    {
    }
}
