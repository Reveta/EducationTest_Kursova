using System.IO;
using EducationTest.Code.Panel.TestPanel.InfoObjects;
using Newtonsoft.Json;

namespace EducationTest.Code.DataStorage.DataBase.JsonManager {
	public class JsonReader {
		public string PathConfigFile { get; set; }

		public JsonReader(string pathConfigFile) { this.PathConfigFile = pathConfigFile; }

		public TestBlock GetNewData() {
			TestBlock config = null;
			if (this.PathConfigFile != null) {
				using (StreamReader r = new StreamReader(path: this.PathConfigFile)) {
					string json = r.ReadToEnd();
					config = JsonConvert.DeserializeObject<TestBlock>(json);
					r.Close();
				}

				return config;
			}

			return config;
		}
	}
}