namespace EducationTest
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
    private void InitializeComponent() {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.Test = new System.Windows.Forms.TabPage();
      this.lessons = new System.Windows.Forms.TabPage();
      this.LessonsLableLessonsPlace = new System.Windows.Forms.Label();
      this.Admin = new System.Windows.Forms.TabPage();
      this.AdminButtonLoadNewTestFile = new System.Windows.Forms.Button();
      this.AdminLabelFilePath = new System.Windows.Forms.Label();
      this.AdminInputFilePath = new System.Windows.Forms.TextBox();
      this.AdminLabelFileLoadedStatus = new System.Windows.Forms.Label();
      this.AdminInputFileLoadedStatus = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.AdminInputStatusConnection = new System.Windows.Forms.TextBox();
      this.AdminConnectButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.AdminPasswordInput = new System.Windows.Forms.TextBox();
      this.AdminUsernameInput = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.Test.SuspendLayout();
      this.lessons.SuspendLayout();
      this.Admin.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.Test);
      this.tabControl1.Controls.Add(this.lessons);
      this.tabControl1.Controls.Add(this.Admin);
      this.tabControl1.Location = new System.Drawing.Point(12, 8);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(909, 498);
      this.tabControl1.TabIndex = 0;
      // 
      // Test
      // 
      this.Test.Controls.Add(this.label4);
      this.Test.Location = new System.Drawing.Point(4, 24);
      this.Test.Name = "Test";
      this.Test.Padding = new System.Windows.Forms.Padding(3);
      this.Test.Size = new System.Drawing.Size(901, 470);
      this.Test.TabIndex = 0;
      this.Test.Text = "Test";
      this.Test.UseVisualStyleBackColor = true;
      // 
      // lessons
      // 
      this.lessons.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lessons.Controls.Add(this.LessonsLableLessonsPlace);
      this.lessons.Location = new System.Drawing.Point(4, 22);
      this.lessons.Name = "lessons";
      this.lessons.Padding = new System.Windows.Forms.Padding(3);
      this.lessons.Size = new System.Drawing.Size(901, 472);
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
      this.Admin.Controls.Add(this.AdminInputFilePath);
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
      // AdminInputFilePath
      // 
      this.AdminInputFilePath.Enabled = false;
      this.AdminInputFilePath.Location = new System.Drawing.Point(168, 204);
      this.AdminInputFilePath.Name = "AdminInputFilePath";
      this.AdminInputFilePath.Size = new System.Drawing.Size(139, 23);
      this.AdminInputFilePath.TabIndex = 9;
      this.AdminInputFilePath.Text = " ";
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
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Segoe UI", 19F);
      this.label4.Location = new System.Drawing.Point(309, 23);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(328, 45);
      this.label4.TabIndex = 0;
      this.label4.Text = "label4";
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(933, 519);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tabControl1.ResumeLayout(false);
      this.Test.ResumeLayout(false);
      this.lessons.ResumeLayout(false);
      this.Admin.ResumeLayout(false);
      this.Admin.PerformLayout();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage Test;
    private System.Windows.Forms.TabPage lessons;
    private System.Windows.Forms.TabPage Admin;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button AdminConnectButton;
    private System.Windows.Forms.TextBox AdminPasswordInput;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label AdminLabelFileLoadedStatus;
    private System.Windows.Forms.TextBox AdminInputFileLoadedStatus;
    private System.Windows.Forms.TextBox AdminUsernameInput;
    private System.Windows.Forms.Label AdminLabelFilePath;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.Label LessonsLableLessonsPlace;
    public System.Windows.Forms.Button AdminButtonLoadNewTestFile;
    public System.Windows.Forms.TextBox AdminInputFilePath;
    public System.Windows.Forms.TextBox AdminInputStatusConnection;
  }
}

