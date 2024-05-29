namespace ToDoApp.Klassen
{
	public class ToDoItem
	{
		private int m_itemID;
		private string m_itemTitle;
		private string m_itemDescription;
		private DateTime m_creationDate;
		private DateTime m_dueDate;
		private ItemState m_itemState;
		private string m_itemCategory;
		private string m_itemOwner;

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
