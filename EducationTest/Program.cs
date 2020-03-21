using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationTest.Code.AdminPanel;
using EducationTest.Code.AdminPanel.AdminBlock;
using EducationTest.Code.AdminPanel.LoginBlock;

namespace EducationTest
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1(new LoginService(), new AdminService()));
    }
  }
}
