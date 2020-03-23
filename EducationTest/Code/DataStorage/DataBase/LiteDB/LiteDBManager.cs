using EducationTest.Code.Panel.TestPanel.InfoObjects;
using LiteDB;

namespace EducationTest.Code.DataStorage.DataBase.LiteDB {
	public class LiteDBManager {
		private LiteDBConfig DbConfig;
		private LiteDatabase LiteDbConnection { get; set; }

		private static LiteDatabase liteDbConnection =
			new LiteDBManager(new LiteDBConfig("database")).GetLiteDbConnection();

		public static ILiteCollection<TestResultOne> GetCollection() {
			return liteDbConnection.GetCollection<TestResultOne>();
		}
		
		private LiteDBManager(LiteDBConfig dbConfig) {
			this.DbConfig = dbConfig;
			if (this.LiteDbConnection == null) {
				this.LiteDbConnection = new LiteDatabase(this.DbConfig.ConfigString);
			}
		}

		private LiteDatabase GetLiteDbConnection() { return this.LiteDbConnection; }
	}
}