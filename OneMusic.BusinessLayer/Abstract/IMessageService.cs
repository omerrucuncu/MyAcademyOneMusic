using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message> // Interface for message-related operations inheriting from a generic service interface
    {
    }
}
