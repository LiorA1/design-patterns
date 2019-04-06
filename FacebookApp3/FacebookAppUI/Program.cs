using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// $G$ DSN-999 (-20) You should separate your solution into several projects

// $G$ THE-001 (-27) your grade on diagrams document - 73 please see comments inside the document. (50% of your grade).

namespace FacebookAppUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFacebookApp());
        }
    }
}