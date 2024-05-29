namespace ToDoApp.Klassen
{
	public class Userclass
	{
		#region Member
		private int m_userID;
		private string m_username;
		private string m_password;
		#endregion

		#region Parameter
		#endregion

		public Userclass(int ID, string Name, string Password)
		{
			m_userID = ID;
			m_username = Name;
			m_password = Password;
		}

		#region Methoden
		public void Login()
		{

		}

		public void Logout()
		{

		}
		#endregion
	}
}
