using System.ComponentModel.DataAnnotations.Schema;
using static ToDoApp.Pages.ToDoListComponent;

namespace ToDoApp.Shared
{
	/// <summary>
	/// Repräsentiert eine Aufgabe in der To-Do Liste. Hat 4 verschiedene Stati (enum Status)
	/// </summary>
	public class ToDoItem
	{
        #region Properties
		/// <summary>
		/// Titel der Aufgabe
		/// </summary>
		public string? Title { get; set; }

		/// <summary>
		/// Zustand in dem sich die Aufgabe befindet
		/// </summary>
		public Status Status {get; set;}

		/// <summary>
		/// Primary Key in der Tabelle ToDoItems in der Datenbank
		/// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		/// <summary>
		/// Gibt an, wann die Aufgabe erstellt wurde
		/// </summary>
        public DateTime? CreationDate { get; set; } = DateTime.Now;

		/// <summary>
		/// Gibt an, bis wann die Aufgabe erledigt sein soll
		/// </summary>
        public DateTime? DueDate { get; set; }

		/// <summary>
		/// Möglichkeit die Aufgabe einer Kategorie (zum Beispiel: Haushalt) zuzuordnen
		/// </summary>
        public string? Category { get; set; }

		/// <summary>
		/// Der Ersteller der Aufgabe
		/// </summary>
        public string? Owner { get; set; }

		/// <summary>
		/// Eine genauere Beschreibung, was die Aufgabe beinhaltet
		/// </summary>
		public string? Description { get; set; }
        #endregion

        #region Konstruktor
        public ToDoItem()
		{

		}
        #endregion
	}
}
