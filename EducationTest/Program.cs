using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationTest.Code.AdminPanel;
using EducationTest.Code.AdminPanel.AdminBlock;
using EducationTest.Code.AdminPanel.LoginBlock;
using EducationTest.Code.DataStorage;
using EducationTest.Code.LessonsPanel;

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
			Application.Run(new Form1(new LoginService(), new AdminService(), new LessonsServices()));
		}
	}
}