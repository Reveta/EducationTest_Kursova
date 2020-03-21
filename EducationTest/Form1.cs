using System;
using System.Windows.Forms;
using EducationTest.Code.AdminPanel;
using EducationTest.Code.AdminPanel.AdminBlock;
using EducationTest.Code.AdminPanel.LoginBlock;

namespace EducationTest {
	public partial class Form1 : Form {
		private readonly ILoginService _loginService;
		private readonly IAdminService _adminService;

		public Form1(ILoginService loginService, IAdminService adminService) {
			this._loginService = loginService;
			this._adminService = adminService;

			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			string username = this.AdminUsernameInput.Text;
			string password = this.AdminPasswordInput.Text;

			bool checkLogin = this._loginService.CheckLogin(username, password);

			if (checkLogin) {
				this._adminService.UnblockElements(this);
			} else {
				this._adminService.BlockElements(this);
			}

			this._loginService.ChangeConnectionStatus(this, checkLogin);
		}
	}
}