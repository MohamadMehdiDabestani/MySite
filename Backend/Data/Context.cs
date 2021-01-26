using Backend.Data;
using Microsoft.EntityFrameworkCore;

namespace Backend
{
    public class Context : DbContext
    {
        public Context(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Post> Post { get; set; }
        public DbSet<MyXp> MyXp { get; set; }
        public DbSet<Projects> Prjects { get; set; }
    }
}