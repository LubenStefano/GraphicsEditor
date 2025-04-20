using System;
using System.Windows.Forms;

namespace GraphicsEditorApp_OOP_course_project
{
    static class Program
    {
   
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }

    }
}
