using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tuckshop
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
        /// </summary>
        /// <param name="s">Enum corresponding to the screen to be shown</param>
        /// <param name="data">If you want to send data to the screen to be opened, this is where it goes</param>
        /// <example>SwitchTo(Screen.Main,"Title Text!","Other Text maybe", 5, 22)</example>
        /// TODO: make sure the previous screen exits properly (there's gotta be an event in the UserControl we can trigger, eg., Unload())
        public static void SwitchTo(Screen s, params object[] data)
        {
            mainForm.SwitchTo(s, data);
        }
    }
}
