using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace apiPersona.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConecction")
        {

        }

        public System.Data.Entity.DbSet<apiPersona.Models.Person> People { get; set; }
    }
}