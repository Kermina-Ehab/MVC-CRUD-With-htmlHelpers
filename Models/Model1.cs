using System;
using System.Data.Entity;
using System.Linq;

namespace CRUDHTNLHELPERS.Models
{
    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CRUDHTNLHELPERS.Models.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        
         public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> employees { get; set; }

    }


}