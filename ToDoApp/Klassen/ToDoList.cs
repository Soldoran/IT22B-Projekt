using System.ComponentModel.DataAnnotations.Schema;
using ToDoApp.Klassen;
using ToDoApp.Shared;

namespace ToDoApp.Klassen
{
	/// <summary>
	/// Repräsentiert die To-Do-Liste, in welcher die To-Do-Items verwaltet werden
	/// </summary>
	public class ToDoList
	{
		/// <summary>
		/// Der Primary Key der Tabelle ToDoLists in der Datenbank
		/// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		public string ListName { get; set; }

		public ToDoList()
		{

		}
	}
}
