using System.Windows.Forms;
using EducationTest.Code.Panel.TestPanel.InfoObjects;

namespace EducationTest.Code.Panel.ResultPanel {
	public class ResultService : IResultService{
		public void AddResultToList(Form form, TestResultOne resultOne) {
			var form1 = form as Form1;

			int id = resultOne.TestOne.Id;
			string body = resultOne.TestOne.Body;
			bool result = resultOne.WasRightAnswer;

			string message = $"Id {id} | {body} | Result is {result} ";

			form1.resultList.Items.Add(message);
		}
	}
}