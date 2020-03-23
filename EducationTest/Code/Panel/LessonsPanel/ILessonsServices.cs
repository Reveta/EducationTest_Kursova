using System.Windows.Forms;

namespace EducationTest.Code.Panel.LessonsPanel {
	public interface ILessonsServices {
		void LoadLessonsFile(Form form, string lessonsFilePath);
	}
}