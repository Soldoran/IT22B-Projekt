using ToDoApp.Klassen;

namespace ToDoApp.Klassen
{
	public class UsersToDoListClass
	{
		private int m_listID;
		private string m_listName;

		public List<ToDoList> ToDoLists { get; set; } = null!;

		public UsersToDoListClass(int listID, string listName)
		{
			m_listID = listID;
			m_listName = listName;
		}

		public void AddToDoList(int listID)
		{

		}

		public void RemoveToDoList(int listID)
		{

		}

		public List<ToDoList> GetLists()
		{
			List<ToDoList> toDos = new();
			return toDos;
		}
	}
}
