using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Klassen
{
    public class Userclass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        public ICollection<ToDoList> ToDoLists { get; set; }

        public async Task<bool> Login(ApplicationDbContext dbContext)
        {
            var user = await dbContext.Userclasses.SingleOrDefaultAsync(u => u.Username == this.Username);
            if (user != null && user.Password == this.Password)
            {
                return true;
            }
            return false;
        }

        public void Logout()
        {
            // Implementieren Sie die Abmeldefunktionalität, falls nötig
        }
    }
}
