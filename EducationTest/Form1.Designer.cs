namespace EducationTest
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    public System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    public void InitializeComponent() {
      this.tab = new System.Windows.Forms.TabControl();
      this.Test = new System.Windows.Forms.TabPage();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.testRadioGroup = new System.Windows.Forms.GroupBox();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.testLabelTestBody = new System.Windows.Forms.Label();
      this.testLabelName = new System.Windows.Forms.Label();
      this.lessons = new System.Windows.Forms.TabPage();
      this.LessonsLableLessonsPlace = new System.Windows.Forms.Label();
      this.Admin = new System.Windows.Forms.TabPage();
      this.AdminButtonLoadNewTestFile = new System.Windows.Forms.Button();
      this.AdminLabelFilePath = new System.Windows.Forms.Label();
      this.AdminInputTestFilePath = new System.Windows.Forms.TextBox();
      this.AdminLabelFileLoadedStatus = new System.Windows.Forms.Label();
      this.AdminInputFileLoadedStatus = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.AdminInputStatusConnection = new System.Windows.Forms.TextBox();
      this.AdminConnectButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.AdminPasswordInput = new System.Windows.Forms.TextBox();
      this.AdminUsernameInput = new System.Windows.Forms.TextBox();
      this.ResultPage = new System.Windows.Forms.TabPage();
      this.resultList = new System.Windows.Forms.ListBox();
      this.tab.SuspendLayout();
      this.Test.SuspendLayout();
      this.testRadioGroup.SuspendLayout();
      this.lessons.SuspendLayout();
      this.Admin.SuspendLayout();
      this.ResultPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // tab
      // 
      this.tab.Controls.Add(this.Test);
      this.tab.Controls.Add(this.lessons);
      this.tab.Controls.Add(this.Admin);
      this.tab.Controls.Add(this.ResultPage);
      this.tab.Location = new System.Drawing.Point(12, 8);
      this.tab.Name = "tab";
      this.tab.SelectedIndex = 0;
      this.tab.Size = new System.Drawing.Size(909, 498);
      this.tab.TabIndex = 0;
      // 
      // Test
      // 
      this.Test.BackColor = System.Drawing.Color.WhiteSmoke;
      this.Test.Controls.Add(this.button3);
      this.Test.Controls.Add(this.button2);
      this.Test.Controls.Add(this.button1);
      this.Test.Controls.Add(this.testRadioGroup);
      this.Test.Controls.Add(this.testLabelTestBody);
      this.Test.Controls.Add(this.testLabelName);
      this.Test.Location = new System.Drawing.Point(4, 24);
      this.Test.Name = "Test";
      this.Test.Padding = new System.Windows.Forms.Padding(3);
      this.Test.Size = new System.Drawing.Size(901, 470);
      this.Test.TabIndex = 0;
      this.Test.Text = "Test";
      // 
      // button3
      // 
      this.button3.Enabled = false;
      this.button3.Location = new System.Drawing.Point(777, 384);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(118, 35);
      this.button3.TabIndex = 5;
      this.button3.Text = "accept answer";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(777, 330);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(118, 35);
      this.button2.TabIndex = 4;
      this.button2.Text = "End Test";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(777, 282);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(118, 35);
      this.button1.TabIndex = 3;
      this.button1.Text = "Start Test";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // testRadioGroup
      // 
      this.testRadioGroup.Controls.Add(this.radioButton4);
      this.testRadioGroup.Controls.Add(this.radioButton3);
      this.testRadioGroup.Controls.Add(this.radioButton2);
      this.testRadioGroup.Controls.Add(this.radioButton1);
      this.testRadioGroup.Location = new System.Drawing.Point(16, 252);
      this.testRadioGroup.Name = "testRadioGroup";
      this.testRadioGroup.Size = new System.Drawing.Size(755, 207);
      this.testRadioGroup.TabIndex = 2;
      this.testRadioGroup.TabStop = false;
      // 
      // radioButton4
      // 
      this.radioButton4.Location = new System.Drawing.Point(15, 156);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(836, 35);
      this.radioButton4.TabIndex = 3;
      this.radioButton4.TabStop = true;
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
      // 
      // radioButton3
      // 
      this.radioButton3.Location = new System.Drawing.Point(15, 119);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(836, 30);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.TabStop = true;
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.Location = new System.Drawing.Point(15, 72);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(836, 41);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.Location = new System.Drawing.Point(15, 30);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(836, 35);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // testLabelTestBody
      // 
      this.testLabelTestBody.Location = new System.Drawing.Point(20, 108);
      this.testLabelTestBody.Name = "testLabelTestBody";
      this.testLabelTestBody.Size = new System.Drawing.Size(863, 123);
      this.testLabelTestBody.TabIndex = 1;
      // 
      // testLabelName
      // 
      this.testLabelName.Font = new System.Drawing.Font("Segoe UI", 19F);
      this.testLabelName.Location = new System.Drawing.Point(20, 27);
      this.testLabelName.Name = "testLabelName";
      this.testLabelName.Size = new System.Drawing.Size(863, 45);
      this.testLabelName.TabIndex = 0;
      this.testLabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lessons
      // 
      this.lessons.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lessons.Controls.Add(this.LessonsLableLessonsPlace);
      this.lessons.Location = new System.Drawing.Point(4, 24);
      this.lessons.Name = "lessons";
      this.lessons.Padding = new System.Windows.Forms.Padding(3);
      this.lessons.Size = new System.Drawing.Size(901, 470);
      this.lessons.TabIndex = 1;
      this.lessons.Text = "Lessons";
      // 
      // LessonsLableLessonsPlace
      // 
      this.LessonsLableLessonsPlace.BackColor = System.Drawing.SystemColors.Window;
      this.LessonsLableLessonsPlace.Enabled = false;
      this.LessonsLableLessonsPlace.Location = new System.Drawing.Point(27, 23);
      this.LessonsLableLessonsPlace.Name = "LessonsLableLessonsPlace";
      this.LessonsLableLessonsPlace.Size = new System.Drawing.Size(853, 432);
      this.LessonsLableLessonsPlace.TabIndex = 0;
      // 
      // Admin
      // 
      this.Admin.BackColor = System.Drawing.Color.WhiteSmoke;
      this.Admin.Controls.Add(this.AdminButtonLoadNewTestFile);
      this.Admin.Controls.Add(this.AdminLabelFilePath);
      this.Admin.Controls.Add(this.AdminInputTestFilePath);
      this.Admin.Controls.Add(this.AdminLabelFileLoadedStatus);
      this.Admin.Controls.Add(this.AdminInputFileLoadedStatus);
      this.Admin.Controls.Add(this.label3);
      this.Admin.Controls.Add(this.AdminInputStatusConnection);
      this.Admin.Controls.Add(this.AdminConnectButton);
      this.Admin.Controls.Add(this.label2);
      this.Admin.Controls.Add(this.label1);
      this.Admin.Controls.Add(this.AdminPasswordInput);
      this.Admin.Controls.Add(this.AdminUsernameInput);
      this.Admin.Location = new System.Drawing.Point(4, 24);
      this.Admin.Name = "Admin";
      this.Admin.Padding = new System.Windows.Forms.Padding(3);
      this.Admin.Size = new System.Drawing.Size(901, 470);
      this.Admin.TabIndex = 2;
      this.Admin.Text = "Admin";
      // 
      // AdminButtonLoadNewTestFile
      // 
      this.AdminButtonLoadNewTestFile.Enabled = false;
      this.AdminButtonLoadNewTestFile.Location = new System.Drawing.Point(168, 245);
      this.AdminButtonLoadNewTestFile.Name = "AdminButtonLoadNewTestFile";
      this.AdminButtonLoadNewTestFile.Size = new System.Drawing.Size(139, 22);
      this.AdminButtonLoadNewTestFile.TabIndex = 11;
      this.AdminButtonLoadNewTestFile.Text = "Load new test file";
      this.AdminButtonLoadNewTestFile.UseVisualStyleBackColor = true;
      this.AdminButtonLoadNewTestFile.Click += new System.EventHandler(this.AdminButtonLoadNewTestFile_Click);
      // 
      // AdminLabelFilePath
      // 
      this.AdminLabelFilePath.Location = new System.Drawing.Point(62, 204);
      this.AdminLabelFilePath.Name = "AdminLabelFilePath";
      this.AdminLabelFilePath.Size = new System.Drawing.Size(100, 23);
      this.AdminLabelFilePath.TabIndex = 10;
      this.AdminLabelFilePath.Text = "Test file`s path is:";
      this.AdminLabelFilePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // AdminInputTestFilePath
      // 
      this.AdminInputTestFilePath.Enabled = false;
      this.AdminInputTestFilePath.Location = new System.Drawing.Point(168, 204);
      this.AdminInputTestFilePath.Name = "AdminInputTestFilePath";
      this.AdminInputTestFilePath.Size = new System.Drawing.Size(139, 23);
      this.AdminInputTestFilePath.TabIndex = 9;
      this.AdminInputTestFilePath.Text = " ";
      // 
      // AdminLabelFileLoadedStatus
      // 
      this.AdminLabelFileLoadedStatus.Location = new System.Drawing.Point(62, 152);
      this.AdminLabelFileLoadedStatus.Name = "AdminLabelFileLoadedStatus";
      this.AdminLabelFileLoadedStatus.Size = new System.Drawing.Size(100, 23);
      this.AdminLabelFileLoadedStatus.TabIndex = 8;
      this.AdminLabelFileLoadedStatus.Text = "Test file is:";
      this.AdminLabelFileLoadedStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // AdminInputFileLoadedStatus
      // 
      this.AdminInputFileLoadedStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.AdminInputFileLoadedStatus.Enabled = false;
      this.AdminInputFileLoadedStatus.Location = new System.Drawing.Point(168, 152);
      this.AdminInputFileLoadedStatus.Name = "AdminInputFileLoadedStatus";
      this.AdminInputFileLoadedStatus.Size = new System.Drawing.Size(139, 16);
      this.AdminInputFileLoadedStatus.TabIndex = 7;
      this.AdminInputFileLoadedStatus.Text = "not loaded";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(295, 65);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(118, 23);
      this.label3.TabIndex = 6;
      this.label3.Text = "Status Connection";
      this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // AdminInputStatusConnection
      // 
      this.AdminInputStatusConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.AdminInputStatusConnection.Enabled = false;
      this.AdminInputStatusConnection.Location = new System.Drawing.Point(419, 65);
      this.AdminInputStatusConnection.Name = "AdminInputStatusConnection";
      this.AdminInputStatusConnection.Size = new System.Drawing.Size(139, 16);
      this.AdminInputStatusConnection.TabIndex = 5;
      this.AdminInputStatusConnection.Text = "Not Connection ";
      this.AdminInputStatusConnection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // AdminConnectButton
      // 
      this.AdminConnectButton.Location = new System.Drawing.Point(717, 29);
      this.AdminConnectButton.Name = "AdminConnectButton";
      this.AdminConnectButton.Size = new System.Drawing.Size(128, 22);
      this.AdminConnectButton.TabIndex = 4;
      this.AdminConnectButton.Text = "Connect";
      this.AdminConnectButton.UseVisualStyleBackColor = true;
      this.AdminConnectButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(398, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Password";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(62, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "AdminName";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // AdminPasswordInput
      // 
      this.AdminPasswordInput.Location = new System.Drawing.Point(504, 29);
      this.AdminPasswordInput.Name = "AdminPasswordInput";
      this.AdminPasswordInput.Size = new System.Drawing.Size(139, 23);
      this.AdminPasswordInput.TabIndex = 1;
      // 
      // AdminUsernameInput
      // 
      this.AdminUsernameInput.Location = new System.Drawing.Point(168, 29);
      this.AdminUsernameInput.Name = "AdminUsernameInput";
      this.AdminUsernameInput.Size = new System.Drawing.Size(139, 23);
      this.AdminUsernameInput.TabIndex = 0;
      this.AdminUsernameInput.Text = "Admin";
      // 
      // ResultPage
      // 
      this.ResultPage.Controls.Add(this.resultList);
      this.ResultPage.Location = new System.Drawing.Point(4, 24);
      this.ResultPage.Name = "ResultPage";
      this.ResultPage.Padding = new System.Windows.Forms.Padding(3);
      this.ResultPage.Size = new System.Drawing.Size(901, 470);
      this.ResultPage.TabIndex = 3;
      this.ResultPage.Text = "Result";
      this.ResultPage.UseVisualStyleBackColor = true;
      // 
      // resultList
      // 
      this.resultList.FormattingEnabled = true;
      this.resultList.ItemHeight = 15;
      this.resultList.Location = new System.Drawing.Point(37, 20);
      this.resultList.Name = "resultList";
      this.resultList.Size = new System.Drawing.Size(823, 424);
      this.resultList.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(933, 519);
      this.Controls.Add(this.tab);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tab.ResumeLayout(false);
      this.Test.ResumeLayout(false);
      this.testRadioGroup.ResumeLayout(false);
      this.lessons.ResumeLayout(false);
      this.Admin.ResumeLayout(false);
      this.Admin.PerformLayout();
      this.ResultPage.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    #endregion

    public System.Windows.Forms.Label testLabelName;
    public System.Windows.Forms.TabPage ResultPage;
    public System.Windows.Forms.TabControl tab;
    public System.Windows.Forms.RadioButton radioButton1;
    public System.Windows.Forms.RadioButton radioButton2;
    public System.Windows.Forms.RadioButton radioButton3;
    public System.Windows.Forms.RadioButton radioButton4;
    public System.Windows.Forms.GroupBox testRadioGroup;
    public System.Windows.Forms.Label testLabelTestBody;
    public System.Windows.Forms.Label LessonsLableLessonsPlace;
    public System.Windows.Forms.Button AdminButtonLoadNewTestFile;
    public System.Windows.Forms.TextBox AdminInputTestFilePath;
    public System.Windows.Forms.TextBox AdminInputStatusConnection;
    public System.Windows.Forms.Button button3;
    public System.Windows.Forms.Button button2;
    public System.Windows.Forms.Button button1;
    public System.Windows.Forms.Label AdminLabelFilePath;
    public System.Windows.Forms.TextBox AdminUsernameInput;
    public System.Windows.Forms.TextBox AdminInputFileLoadedStatus;
    public System.Windows.Forms.Label AdminLabelFileLoadedStatus;
    public System.Windows.Forms.Label label3;
    public System.Windows.Forms.TextBox AdminPasswordInput;
    public System.Windows.Forms.Button AdminConnectButton;
    public System.Windows.Forms.Label label2;
    public System.Windows.Forms.Label label1;
    public System.Windows.Forms.TabPage Admin;
    public System.Windows.Forms.TabPage lessons;
    public System.Windows.Forms.TabPage Test;
    public System.Windows.Forms.ListBox resultList;
  }
}

