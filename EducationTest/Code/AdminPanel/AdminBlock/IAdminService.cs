using System.Windows.Forms;

namespace EducationTest.Code.AdminPanel.AdminBlock {
	public interface IAdminService {
		void BlockElements(Form form);
		void UnblockElements(Form form);
	}
}