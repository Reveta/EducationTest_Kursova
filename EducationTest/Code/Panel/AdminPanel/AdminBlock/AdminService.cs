using System.Data.SqlTypes;
using System.Windows.Forms;

namespace EducationTest.Code.Panel.AdminPanel.AdminBlock {
	public class AdminService : IAdminService {
		public void BlockElements(Form form) {
			Form1 form1 = form as Form1;

			form1.AdminInputTestFilePath.Enabled = false;
			form1.AdminButtonLoadNewTestFile.Enabled = false;
		}

		public void UnblockElements(Form form) {
			Form1 form1 = form as Form1;

			form1.AdminInputTestFilePath.Enabled = true;
			form1.AdminButtonLoadNewTestFile.Enabled = true;
		}

		public void UpdateTestFilePath(Form form) {
			Form1 form1 = form as Form1;

			string newTestFilePath = form1.AdminInputTestFilePath.Text;
			DataStorage.DataStorage.TestFilePath = newTestFilePath;
		}
	}
}