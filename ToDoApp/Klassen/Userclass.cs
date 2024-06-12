using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Klassen
{
    /// <summary>
    /// Repräsentiert einen Benutzer der Anwendung. Hat die möglichkeit sich bei der Anwendung mit seinem Username und Password anzumelden.
    /// </summary>
    public class Userclass
    {
        /// <summary>
        /// Primary Key in der Datenbanktabelle Userclasses
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
