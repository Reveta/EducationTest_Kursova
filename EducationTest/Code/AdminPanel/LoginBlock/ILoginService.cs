using System.Windows.Forms;

namespace EducationTest.Code.AdminPanel.LoginBlock {
	public interface ILoginService {
		bool CheckLogin(string username, string password);
		void ChangeConnectionStatus(Form form, bool status);
	}
}