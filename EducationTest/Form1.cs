using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EducationTest.Code.DataStorage;
using EducationTest.Code.DataStorage.DataBase.LiteDB;
using EducationTest.Code.Panel.AdminPanel.AdminBlock;
using EducationTest.Code.Panel.AdminPanel.LoginBlock;
using EducationTest.Code.Panel.LessonsPanel;
using EducationTest.Code.Panel.ResultPanel;
using EducationTest.Code.Panel.TestPanel;
using EducationTest.Code.Panel.TestPanel.InfoObjects;
using LiteDB;

namespace EducationTest {
	public partial class Form1 : Form {
		private readonly ILoginService _loginService;
		private readonly IAdminService _adminService;
		private readonly ILessonsServices _lessonsServices;
		private readonly ITestServices _testServices;
		private readonly IResultService _resultService;

		public Form1(ILoginService loginService,
			IAdminService adminService,
			ILessonsServices lessonsServices,
			ITestServices testServices,
			IResultService resultService) {
			InitializeComponent();

			this._loginService = loginService;
			this._adminService = adminService;
			this._testServices = testServices;
			this._resultService = resultService;
			this._lessonsServices = lessonsServices;
			lessonsServices.LoadLessonsFile(this, DataStorage.LessonFilePath);

			List<TestResultOne> oldResults = LiteDBManager.GetCollection().FindAll().ToList();
			oldResults.ForEach(one => resultService.AddResultToList(this, one));
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

		private void AdminButtonLoadNewTestFile_Click(object sender, EventArgs e) {
			this._adminService.UpdateTestFilePath(this);

			if (File.Exists(DataStorage.TestFilePath)) {
				var jsonReader =
					new EducationTest.Code.DataStorage.DataBase.JsonManager.JsonReader(DataStorage.TestFilePath);
				this._testServices.LoadTestToPage(this, jsonReader.GetNewData());
			}
		}


		private void button1_Click_1(object sender, EventArgs e) {
			if (DataStorage.TestFilePath.Equals("nool")) {
				return;
			}

			this._testServices.StartTest(this);
		}

		private void button2_Click(object sender, EventArgs e) { this._testServices.EndTest(this); }

		private void button3_Click(object sender, EventArgs e) { this._testServices.AcceptAnswer(this); }


		private void radioButton1_CheckedChanged(object sender, EventArgs e) { this.button3.Enabled = true; }
		private void radioButton2_CheckedChanged(object sender, EventArgs e) { this.button3.Enabled = true; }
		private void radioButton3_CheckedChanged(object sender, EventArgs e) { this.button3.Enabled = true; }
		private void radioButton4_CheckedChanged(object sender, EventArgs e) { this.button3.Enabled = true; }
	}
}