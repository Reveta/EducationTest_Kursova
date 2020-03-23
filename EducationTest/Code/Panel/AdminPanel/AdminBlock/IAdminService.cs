using System.Windows.Forms;

namespace EducationTest.Code.Panel.AdminPanel.AdminBlock {
	public interface IAdminService {
		void BlockElements(Form form);
		void UnblockElements(Form form);

		void UpdateTestFilePath(Form form);
	}
}