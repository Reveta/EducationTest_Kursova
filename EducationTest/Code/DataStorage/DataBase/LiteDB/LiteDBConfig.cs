namespace EducationTest.Code.DataStorage.DataBase.LiteDB {
	public class LiteDBConfig {
		public string ConfigString { get; }

		public LiteDBConfig(string name) { this.ConfigString = $"Filename={name}.litedb4"; }
	}
}