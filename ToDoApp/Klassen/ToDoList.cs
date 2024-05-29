using ToDoApp.Klassen;

namespace ToDoApp.Klassen
{
	public class ToDoList
	{
		private int m_listID;
		private string m_listName;

		public ToDoList(int listID, string listName)
		{
			m_listID = listID;
			m_listName = listName;
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
