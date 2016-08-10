using Microsoft.EntityFrameworkCore;

namespace com.profillingTool.models
{
    class ProfileContext : DbContext
    {
        public DbSet<Profile> Profile { get; set; }

     public ProfileContext (DbContextOptions<ProfileContext> options)
     :base (options)
     {
       
     }

     /*   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=./Profile.db");
    }*/
    }
    
}