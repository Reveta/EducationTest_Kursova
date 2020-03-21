using System.Collections.Generic;
using System.Windows.Forms;
using EducationTest.Code.TestPage.InfoObjects;

namespace EducationTest.Code.TestPage {
	public interface ITestServices {
		void LoadTestToPage(Form form, List<TestBlock> blocks);
	}

}