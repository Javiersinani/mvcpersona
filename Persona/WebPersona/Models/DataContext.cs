using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebPersona.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConecction")
        {
                
        }

        public System.Data.Entity.DbSet<WebPersona.Models.Person> People { get; set; }
    }
}