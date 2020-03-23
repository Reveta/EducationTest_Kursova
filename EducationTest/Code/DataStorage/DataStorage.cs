using System;
using System.Collections.Generic;
using EducationTest.Code.Panel.TestPanel.InfoObjects;

namespace EducationTest.Code.DataStorage {
	public class DataStorage {
		public static bool ConnectionStatus = false;
		public static string TestFilePath = "nool";
		public static string LessonFilePath = "";
		public static readonly List<TestResultOne> listOfResults = new List<TestResultOne>();
	}
}