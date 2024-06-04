using Microsoft.EntityFrameworkCore;
using ToDoApp.Shared;

namespace ToDoApp.Klassen
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<Userclass> Userclasses { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }
    }
}
