using System;
using System.Windows.Forms;

namespace EducationTest.Code.AdminPanel.LoginBlock {
	public class LoginService : ILoginService{
		
		public bool CheckLogin(string username, string password) {
			string rightAdminName = "Admin";
			string rightPassword = "1234";

			return username.Equals(rightAdminName) && password.Equals(rightPassword);
		}

		public void ChangeConnectionStatus(Form form, bool status) {
			Form1 form1 = form as Form1;

			string statusTrue = "is connected";
			string statusFalse = "in not connected";

			form1.AdminInputStatusConnection.Text = status ? statusTrue : statusFalse;
		}
	}
}