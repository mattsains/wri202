using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI_Skeleton
{
    static class Program
    {
        static private MainForm mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
        }

        /// <summary>
        /// Switches the screen displayed on the main form
        /// This method drops the current screen, so make sure it's done whatever it was doing.
        /// TODO: make sure the previous screen exits properly (there's gotta be an event in the UserControl we can trigger, eg., Unload())
        /// </summary>
        /// <param name="s">Enum corresponding to the screen to be shown</param>
        public static void SwitchTo(Screen s)
        {
            mainForm.SwitchTo(s);
        }
    }
}
