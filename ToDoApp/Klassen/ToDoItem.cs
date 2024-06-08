using System.ComponentModel.DataAnnotations.Schema;
using static ToDoApp.Pages.ToDoListComponent;

namespace ToDoApp.Shared
{
	public class ToDoItem
	{
		public string? Title { get; set; }

		public Status Status {get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime? CreationDate { get; set; } = DateTime.Now;

        public DateTime? DueDate { get; set; }

        public string? Category { get; set; }

        public string? Owner { get; set; }

		public string? Description { get; set; }

        public ToDoItem()
		{

		}
	}
}
