using System.Collections.Generic;

namespace EducationTest.Code.TestPage.InfoObjects {
	public class TestOne {
		public int Id { get; set; }
		public string Body { get; set; }
		public List<TestAnswers> TestAnswersList { get; set; }
	}
}