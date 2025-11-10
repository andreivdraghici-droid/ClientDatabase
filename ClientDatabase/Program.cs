using System;
using System.Windows.Forms;
using ClientDatabase.Forms;

namespace ClientDatabase
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
            StartWindow programForm = new StartWindow();
            programForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(programForm);
        }
    }
}