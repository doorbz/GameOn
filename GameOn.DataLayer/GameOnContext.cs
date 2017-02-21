using System.Data.Entity;
using GameOn.ModelClasses;

namespace GameOn.DataLayer
{
    public class GameOnContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}
