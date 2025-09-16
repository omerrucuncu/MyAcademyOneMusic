using Microsoft.EntityFrameworkCore;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Context
{
    public class OneMusicContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // This method configures the database connection
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NBMSEF4\\SQLEXPRESS;database=OneMusicDb;integrated security=true;trustServerCertificate=true"); // Connection string to the SQL Server database
        }

        public DbSet<Song> Songs { get; set; } // Represents the Songs table in the database
        public DbSet<Album> Albums { get; set; } // Represents the Albums table in the database
        public DbSet<Singer> Singers { get; set; } // Represents the Singers table in the database
        public DbSet<Message> Messages { get; set; } // Represents the Messages table in the database
        public DbSet<Banner> Banners { get; set; } // Represents the Banners table in the database
        public DbSet<About> Abouts { get; set; } // Represents the Abouts table in the database
        public DbSet<Contact> Contacts { get; set; } // Represents the Contacts table in the database

    }
}
