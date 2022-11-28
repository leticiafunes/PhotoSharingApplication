using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PhotoSharingApplication.Data;
using PhotoSharingApplication.Models;


namespace PhotoSharingApplication.Data
{
    public class PhotoDBContext : DbContext

    {
        public PhotoDBContext() : base("keyPhotoDB") { }

        public DbSet<Photo> Photos { get; set; }


    }

}
