using System.ComponentModel.DataAnnotations.Schema;
using static ToDoApp.Pages.ToDoListComponent;

namespace ToDoApp.Shared
{
	public class ToDoItem
	{
		public string? Title { get; set; }
		public bool IsDone { get; set; } = false;
		public Status Status {get; set;}
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ToDoItem()
		{

		}

		public void MarkAsCompleted()
		{

		}
	}

	enum ItemState
	{
		Open = 0,
		inBearbeitung = 1,
		Closed = 2
	}
}
