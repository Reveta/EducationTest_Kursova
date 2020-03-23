using System;
using System.Windows.Forms;
using EducationTest.Code.DataStorage;
using EducationTest.Code.Panel.AdminPanel.AdminBlock;
using EducationTest.Code.Panel.AdminPanel.LoginBlock;
using EducationTest.Code.Panel.LessonsPanel;
using EducationTest.Code.Panel.ResultPanel;
using EducationTest.Code.Panel.TestPanel;

namespace EducationTest {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			DataStorage.LessonFilePath = "resources\\lessonFile.txt";

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1(
				new LoginService(),
				new AdminService(),
				new LessonsServices(),
				new TestServices(),
				new ResultService()));
		}
	}
}