using System.Windows.Forms;

namespace EducationTest.Code.LessonsPanel {
	public interface ILessonsServices {
		void LoadLessonsFile(Form form, string lessonsFilePath);
	}
}