using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AnimeDB.Data
{
    public class ApplicationContext : DbContext 
    {
        public DbSet<AnimeDB.Models.Data.Anime> Animes { get; set; }
        public DbSet<AnimeDB.Models.Data.Author> Authors { get; set; }
        public DbSet<AnimeDB.Models.Data.Character> Characters { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}
}
