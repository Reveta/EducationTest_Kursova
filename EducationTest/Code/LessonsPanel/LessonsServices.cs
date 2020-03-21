using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EducationTest.Code.LessonsPanel {
	public class LessonsServices : ILessonsServices{
		public void LoadLessonsFile(Form form, string lessonsFilePath) {
			Form1 form1 = form as Form1;
			bool exists = File.Exists(lessonsFilePath);

			if (exists) {
				string text = File.ReadAllText(lessonsFilePath);
				form1.LessonsLableLessonsPlace.ForeColor = Color.Black;
				form1.LessonsLableLessonsPlace.Text = text;
			}
		}
	}
}