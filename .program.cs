using System;
using System.Windows.Forms;
using SemiFinalActivity2;

namespace YourFamilyname_Activity2
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
            Application.Run(new StudentForm());
        }
    }
}
