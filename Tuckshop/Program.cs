using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

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
            DataProvider.Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TSM.accdb;");
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

        /// <summary>
        /// Shows an error message and handles OK and Cancel buttons
        /// If Cancel is clicked, goes to the 'previous' screen.
        /// If OK is clicked, optionally highlights the entryControl control.
        /// </summary>
        /// <param name="title">The title for the message box to show</param>
        /// <param name="message">The message in the message box</param>
        /// <param name="previous">the screen to go to if the user clicks cancel</param>
        /// <param name="entryControl">the control with incorrect data. This control must be based on a textbox. Null is ok</param>
        public static void ShowError(string title, string message, Screen previous, TextBoxBase entryControl = null)
        {
            DialogResult response = MessageBox.Show(message, title, MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (response == DialogResult.Cancel)
                Program.SwitchTo(previous);
            else if (entryControl != null)
            {
                entryControl.Focus();
                entryControl.SelectAll();
            }
        }
    }
}
