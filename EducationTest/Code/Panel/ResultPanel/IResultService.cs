using System.Windows.Forms;
using EducationTest.Code.Panel.TestPanel.InfoObjects;

namespace EducationTest.Code.Panel.ResultPanel {
	public interface IResultService {
		void AddResultToList(Form form, TestResultOne resultOne);
	}
}