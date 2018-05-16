using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;


namespace Exercise11Mvc.DataAccessLayer
{
    public class StorageContext : DbContext
    {

        public StorageContext() : base ("DefaultConnection")
        {

        }
         public DbSet<Models.Product> Products { get; set; }
       
        
    }
}