using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EducationTest.Code.DataStorage.DataBase.LiteDB;
using EducationTest.Code.Panel.ResultPanel;

namespace EducationTest.Code.Panel.TestPanel.InfoObjects {
	public class TestBlock {
		public int Id { get; set; }
		public string Name { get; set; }
		public List<TestOne> TestOnesList { get; set; }
		public TestOne TestActual { get; set; }
		public int testOneId;
		public int lastTestOneId;

		public void StartTest(Form form) {
			Form1 form1 = form as Form1;

			form1.radioButton1.Enabled = true;
			form1.radioButton2.Enabled = true;
			form1.radioButton3.Enabled = true;
			form1.radioButton4.Enabled = true;

			this.lastTestOneId = this.TestOnesList.Count;
			this.testOneId = 0;

			this.TestActual = this.TestOnesList[this.testOneId];
			LoadAnswerToForm(form1);
		}

		public void AcceptAnswer(Form form) {
			Form1 form1 = form as Form1;

			TestResultOne resultOne = new TestResultOne() {
				TestOne = this.TestActual,
				WasRightAnswer = CheckIsRightAnswer(form1)
			};

			DataStorage.DataStorage.listOfResults.Add(resultOne);
			new ResultService().AddResultToList(form1, resultOne);
			LiteDBManager.GetCollection().Insert(resultOne);

			try {
				this.testOneId += 1;

				if (this.testOneId <= this.lastTestOneId) {
					this.TestActual = this.TestOnesList[this.testOneId];
					LoadAnswerToForm(form1);
				} else {
					form1.testLabelName.Text = "It`s end!";
					EndTest(form1);
				}
			} catch (Exception ignore) { }
		}

		public TestBlock EndTest(Form form) {
			Form1 form1 = form as Form1;

			form1.radioButton1.Enabled = false;
			form1.radioButton2.Enabled = false;
			form1.radioButton3.Enabled = false;
			form1.radioButton4.Enabled = false;
			form1.button3.Enabled = false;

			return this;
		}

		private void LoadAnswerToForm(Form1 form) {
			form.testLabelName.Text = this.Name;
			form.testLabelTestBody.Text = this.TestActual.Body;
			form.radioButton1.Text = this.TestActual.TestAnswersList[0].Body;
			form.radioButton2.Text = this.TestActual.TestAnswersList[1].Body;
			form.radioButton3.Text = this.TestActual.TestAnswersList[2].Body;
			form.radioButton4.Text = this.TestActual.TestAnswersList[3].Body;
			form.button3.Enabled = false;
		}

		private bool CheckIsRightAnswer(Form1 form) {
			List<RadioButton> radioList = new List<RadioButton>() {
				form.radioButton1,
				form.radioButton2,
				form.radioButton3,
				form.radioButton4
			};

			string rightAnswer = this.TestActual.TestAnswersList.First(answers => answers.IsItRight).Body;
			string checkedRadioButton = radioList.First(check => check.Checked).Text;

			return rightAnswer.Equals(checkedRadioButton);
		}
	}
}