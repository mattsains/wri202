using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

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
            DialogResult response = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Cancel)
                Program.SwitchTo(previous);
            else if (entryControl != null)
            {
                entryControl.Focus();
                entryControl.SelectAll();
            }
        }


        public static void PrintSalesSheet()
        {
            Random r = new Random();
            string fileName = Path.GetTempPath() + "salessheet" + r.Next(100000) + ".htm";
            StreamWriter xml = new StreamWriter(fileName);

            xml.WriteLine(
@"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">
<html>
	<head>
		<title></title>
            <style type=""text/css"">
            body
            {
                font-family:""Microsoft Sans Serif"";
            }
            td
            {
                border:1px solid #000;
                padding:5px;
            }
            th
            {
                padding:5px;
            }
            h2
            {
              font-size: 16px; 
              font-weight: normal;                
            }
            table
            {
                border-collapse:collapse;
            }
            #col3
            {
                width:450px;  
            }
            #col2
            {
                width:50px;  
            }
            #col1
            {
                width:  150px;
            }
        </style>
	</head>
	<body>");
            xml.WriteLine(
        @"<h2>Please write down the name of the item(s) you which to purchase followed by the quantity of each.</h2>
        <h2>Money will be collected at the end of the month.</h2>
        <table>
            <tr><th id=""col1"">Name</th><th id=""col2"">Staff No.</th><th id=""col3"">Item(s)</th></tr>");
            foreach (Staff s in Staff.All())
            {
                xml.WriteLine("<tr><td>" + s.FirstName + " " + s.Surname + "</td><td>" + s.StaffNum + "</td><td></td></tr>");
            }
            xml.WriteLine(
@"        </table>
	</body>
</html>");
            xml.Close();
            Program.SwitchTo(Screen.PrintPreview, "Sales Sheet", "file://" + fileName);
        }

        public static void PrintStockList(DateTime date, string title, DataGridViewRowCollection rows)
        {
            Random r = new Random();
            string fileName = Path.GetTempPath() + "stocklist" + r.Next(100000) + ".htm";
            StreamWriter xml = new StreamWriter(fileName);

            xml.WriteLine(
@"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">
<html>
    <head>
    <style type=""text/css"">
            body
            {
                font-family:""Microsoft Sans Serif"";
            }
            td
            {
                border:1px solid #000;
                padding:5px;
            }
            th
            {
                padding:5px;
            }
            table
            {
                border-collapse:collapse;
            }
        </style>
    </head>
	<body>");
            xml.WriteLine("<h1>" + title + "</h1>");
            xml.WriteLine("<h2>" + date.ToLongDateString() + "</h2>");
            xml.WriteLine(@"<table>
            <tr><th>Item Num</th><th>Description</th><th>Price</th></tr>");
            foreach (DataGridViewRow row in rows)
            {
                xml.WriteLine("<tr><td>" + row.Cells[0].FormattedValue + "</td><td>" + row.Cells[2].FormattedValue + "</td><td>" + row.Cells[4].FormattedValue + "</td></tr>");
            }
            xml.WriteLine(
@"        </table>
	</body>
</html>");
            xml.Close();
            Program.SwitchTo(Screen.PrintPreview, "Stock List", "file://" + fileName);
        }
    }
}
