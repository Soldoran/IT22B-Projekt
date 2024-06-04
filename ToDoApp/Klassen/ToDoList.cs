using System.ComponentModel.DataAnnotations.Schema;
using ToDoApp.Klassen;
using ToDoApp.Shared;

namespace ToDoApp.Klassen
{
	public class ToDoList
	{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string ListName { get; set; }

		public ToDoList()
		{

		}

		public void AddItem(ToDoItem item)
		{

		}

		public void RemoveItem()
		{

		}

		public List<ToDoItem> GetItems()
		{
			List<ToDoItem> itemList = new();
			return itemList;
		}
	}
}
