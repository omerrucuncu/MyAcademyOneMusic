using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.EntityLayer.Entities
{
    public class Singer // Represents a singer entity in the application
    {
        public int SingerId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        





        public List<Album> Albums { get; set; }
    }
}
