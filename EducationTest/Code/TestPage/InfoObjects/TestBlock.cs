using System.Collections.Generic;

namespace EducationTest.Code.TestPage.InfoObjects {
	public class TestBlock {
		public int Id { get; set; }
		public string Name { get; set; }
		public List<TestOne> testList { get; set; }
		
	}
}