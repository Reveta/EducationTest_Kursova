using System.Windows.Forms;

namespace EducationTest.Code.AdminPanel.AdminBlock {
	public class AdminService : IAdminService {
		public void BlockElements(Form form) {
			Form1 form1 = form as Form1;

			form1.AdminInputFilePath.Enabled = false;
			form1.AdminButtonLoadNewTestFile.Enabled = false;
		}

		public void UnblockElements(Form form) {
			Form1 form1 = form as Form1;

			form1.AdminInputFilePath.Enabled = true;
			form1.AdminButtonLoadNewTestFile.Enabled = true;
		}
	}
}