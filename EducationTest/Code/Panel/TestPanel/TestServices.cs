using System.Windows.Forms;
using EducationTest.Code.Panel.TestPanel.InfoObjects;

namespace EducationTest.Code.Panel.TestPanel {
	public class TestServices : ITestServices {
		private TestBlock _testBlockActual;

		public void LoadTestToPage(Form form, TestBlock testBlock) {
			this._testBlockActual = testBlock;
		}


		public void StartTest(Form form) {
			this._testBlockActual.StartTest(form);
			
		}

		public TestBlock EndTest(Form form) {
			TestBlock endTest = this._testBlockActual.EndTest(form);
			return endTest;
		}

		public void AcceptAnswer(Form form) {
			this._testBlockActual.AcceptAnswer(form);
		}

	}
}