using Microsoft.EntityFrameworkCore;
using ToDoApp.Shared;

namespace ToDoApp.Klassen
{
    public class ApplicationDbContext : DbContext
    {
        #region Member
        protected readonly IConfiguration Configuration;
        #endregion

        #region Konstruktor
        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region DbSets
        // Definieren die Tabellen, welche auf Basis der angegebenen Klassen erstellt werden sollen
        public DbSet<Userclass> Userclasses { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        #endregion

        #region OnConfiguring
        /// <summary>
        /// Holt sich den in den appsettings.json definierten DbConnectionstring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }
        #endregion
    }
}
