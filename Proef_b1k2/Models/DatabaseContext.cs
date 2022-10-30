using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proef_b1k2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=Dbconnstringb1k2Test")
        {

        }
        public DbSet<Speler> Spelers { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Aanmelding> Aanmeldings { get; set; }
        public DbSet<Toernooi> Toernoois { get; set; }
        public DbSet<Wedstrijd> Wedstrijds { get; set; }
    }
}