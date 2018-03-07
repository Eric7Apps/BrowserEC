using System;
using System.Collections.Generic;
// using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace BrowserEC
{
  static class Program
  {
  [STAThread]
  static void Main()
    {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    Application.ThreadException += new ThreadExceptionEventHandler( MainForm.UIThreadException );
    Application.SetUnhandledExceptionMode( UnhandledExceptionMode.CatchException );

    // AppDomain.CurrentDomain.UnhandledException +=
      //  new UnhandledExceptionEventHandler( CurrentDomain_UnhandledException );

    Application.Run(new MainForm());
    }
  }
}
