using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecarouselGrid.Model
{

    public class DbBridge : DbContext
    {
        //Default Constructor
        public DbBridge() { }

        //Constructor -- create the Database -- works with different classes (Just do this!)
        public DbBridge(DbContextOptions<DbBridge> options) : base(options) { }

        //Table in the database; each table gets its own line.
        //public DbSet<ENTER-TABLENAME-HERE> ENTER-TABLENAME-HERE {get; set;}
        public DbSet<Greetings> Greetings { get; set; }

    }
}
