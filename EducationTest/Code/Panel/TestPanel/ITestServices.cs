using System.Windows.Forms;
using EducationTest.Code.Panel.TestPanel.InfoObjects;

namespace EducationTest.Code.Panel.TestPanel {
	public interface ITestServices {
		void LoadTestToPage(Form form, TestBlock testBlock);

		void StartTest(Form form);
		TestBlock EndTest(Form form);

		void AcceptAnswer(Form form);
	}

}